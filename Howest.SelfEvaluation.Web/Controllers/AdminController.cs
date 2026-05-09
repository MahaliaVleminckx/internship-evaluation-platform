using Howest.SelfEvaluation.Core.Entities;
using Howest.SelfEvaluation.Web.Data;
using Howest.SelfEvaluation.Web.ViewModels.Admin;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Providers;


namespace Howest.SelfEvaluation.Web.Controllers
{
    public class AdminController : Controller
    {
        private readonly SelfEvaluationsContext _db;

        public AdminController (SelfEvaluationsContext db)
        {
            _db = db;
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
            var query = _db.ApplicationUsers.AsQueryable();

            //Filter op role
            if (!string.IsNullOrEmpty(role))
            {
                query = query.Where(u => u.Role == role);
            }

            var vm = new AdminUsersViewModel
            {
                Users = await query.ToListAsync(),
                SelectedRole = role
            };

            return View(vm);
           
        }

        [HttpGet]
        public IActionResult CreateUser()
        {
            return View(new ApplicationUser());
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserViewModel vm)
        {
            if (!ModelState.IsValid)
                return View(vm);

            var user = new ApplicationUser
            {
                Id = Guid.NewGuid(),
                Firstname = vm.Firstname,
                Lastname = vm.Lastname,
                Username = vm.Username,
                Role = vm.Role,
                Created = DateTime.Now,
                Deleted = null,
                AssignedMentorId = null
            };

            _db.ApplicationUsers.Add(user);
            await _db.SaveChangesAsync();

            return RedirectToAction("Users");
        }

        public async Task<IActionResult> DeactivateUser (Guid id)
        {
            var user = await _db.ApplicationUsers.FindAsync (id);
            if (user == null)
            {
                return NotFound();
            }
            user.Deleted = DateTime.Now;
            await _db.SaveChangesAsync();
            return RedirectToAction("Users");
        }

        public async Task<IActionResult> ReactivateUser(Guid id)
        {
            var user = await _db.ApplicationUsers.FindAsync (id);
            if (user == null)
            {
                return NotFound();
            }
            user.Deleted = null;
            await _db.SaveChangesAsync();
            return RedirectToAction("Users");
        }
    }
}
