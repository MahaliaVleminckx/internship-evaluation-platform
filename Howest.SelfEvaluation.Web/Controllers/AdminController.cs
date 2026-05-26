using Azure.Identity;
using Howest.SelfEvaluation.Core.Entities;
using Howest.SelfEvaluation.Web.Data;
using Howest.SelfEvaluation.Web.Services;
using Howest.SelfEvaluation.Web.ViewModels.Admin;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Providers;


namespace Howest.SelfEvaluation.Web.Controllers
{
    public class AdminController : Controller
    {
        private readonly SelfEvaluationsContext _db;
        private readonly AdminUserService _adminUserService;

        public AdminController(SelfEvaluationsContext db, AdminUserService adminUserService)
        {
            _db = db;
            _adminUserService = adminUserService;
        }


        [HttpGet]

        public async Task<IActionResult> CreateModule()
        {
            var vm = new AdminCreateModuleViewModel
            {
                Students = await _db.ApplicationUsers.Where(u => u.Role == "Student").ToListAsync(),
                Teachers = await _db.ApplicationUsers.Where(u => u.Role == "Teacher").ToListAsync()
            };
            return View(vm);
        }

        [HttpPost]

        public async Task<IActionResult> CreateModule(AdminCreateModuleViewModel vm)
        {
            if (!ModelState.IsValid || vm.OwnerId == null)
            {
                return View(vm);
            }
            var module = new Module
            {
                Id = Guid.NewGuid(),
                Name = vm.Name,
                Description = vm.Description,
                OwnerId = vm.OwnerId,
                Created = DateTime.Now
            };

            _db.Modules.Add(module);


            //Had to change this as I updated the db relationship from own class to automatic through EF

            //_db.Set<ApplicationUserModule>().Add(new ApplicationUserModule
            //{
            //    ApplicationUserId = vm.OwnerId.Value,
            //    ModuleId = module.Id
            //});

            var owner = await _db.ApplicationUsers.FindAsync(vm.OwnerId.Value);
            module.ApplicationUsers.Add(owner);

            foreach (var studentId in vm.AssignedStudentIds)
            {
                //idem 

                //_db.Set<ApplicationUserModule>().Add(new ApplicationUserModule
                //{
                //    ApplicationUserId = studentId,
                //    ModuleId = module.Id
                //});
                var student = await _db.ApplicationUsers.FindAsync(studentId);
                module.ApplicationUsers.Add(student);
            }


            await _db.SaveChangesAsync();
            return RedirectToAction("CreateModule");
        }

        //Admin user overview pagina
        [HttpGet]
        public async Task<IActionResult> Users(string? role)
        {
            var users = await _adminUserService.GetUsers(role);

            var vm = new AdminUsersViewModel
            {
                Users = users.Select(u => new AdminUserItemsViewModel
                {
                    Id = u.Id,
                    Username = u.Username,
                    Firstname = u.Firstname,
                    Lastname = u.Lastname,
                    Role = u.Role,
                    Created = u.Created,
                    Deleted = u.Deleted
                }).ToList(),
                SelectedRole = role
            };

            return View(vm);

        }

        [HttpGet]
        public IActionResult CreateUser()
        {
            return View(new AdminCreateUsersViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(AdminCreateUsersViewModel vm)
        {
            if (!ModelState.IsValid)
                return View(vm);

            var user = new ApplicationUser
            {
                Id = Guid.NewGuid(),
                Firstname = vm.Firstname,
                Lastname = vm.Lastname,
                Username = vm.Username.ToLowerInvariant(),
                Role = vm.Role,
                Created = DateTime.Now,
                Deleted = null,
                AssignedMentorId = null
            };

            await _adminUserService.CreateAsync(user);

            return RedirectToAction("Users");
        }

        [HttpGet]
        public async Task<IActionResult> EditUser(Guid id)
        {
            var user = await _adminUserService.GetByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            var vm = new AdminEditUsersViewModel
            {
                Id = user.Id,
                Firstname = user.Firstname,
                Lastname = user.Lastname,
                Username = user.Username.ToLowerInvariant(),
                Role = user.Role
            };
            return View(vm);
        }
        [HttpPost]
        public async Task<IActionResult> EditUser(AdminEditUsersViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }

            var user = await _adminUserService.GetByIdAsync(vm.Id);
            if (user == null)
            {
                return NotFound();
            }

            user.Firstname = vm.Firstname;
            user.Lastname = vm.Lastname;
            user.Username = vm.Username.ToLowerInvariant();
            user.Role = vm.Role;
            user.Updated = DateTime.Now;

            await _adminUserService.UpdateAsync(user);
            return RedirectToAction("Users");
        }
        public async Task<IActionResult> DeactivateUser(Guid id)
        {
            var user = await _adminUserService.GetByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            await _adminUserService.DeactivateAsync(user);
            return RedirectToAction("Users");
        }

        public async Task<IActionResult> ReactivateUser(Guid id)
        {
           
            var user = await _adminUserService.GetByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            await _adminUserService.ReactivateAsync(user);
            return RedirectToAction("Users");
        }
    }
}
