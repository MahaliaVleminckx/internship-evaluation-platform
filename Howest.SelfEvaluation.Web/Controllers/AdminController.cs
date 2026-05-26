using Azure.Identity;
using Howest.SelfEvaluation.Core.Entities;
using Howest.SelfEvaluation.Web.Data;
using Howest.SelfEvaluation.Web.Models;
using Howest.SelfEvaluation.Web.Services.Interfaces;
using Howest.SelfEvaluation.Web.ViewModels;
using Howest.SelfEvaluation.Web.Services;
using Howest.SelfEvaluation.Web.ViewModels.Admin;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using NuGet.Protocol.Providers;
using NuGet.Versioning;


namespace Howest.SelfEvaluation.Web.Controllers
{
    public class AdminController : Controller
    {
        private readonly SelfEvaluationsDbContext _db;
        private readonly IEvaluationService _evaluationService;
        private readonly IFormBuilderService _formBuilderService;
        private readonly AdminUserService _adminUserService;

        public AdminController(SelfEvaluationsDbContext db, IEvaluationService evaluationService, IFormBuilderService formBuilderService, AdminUserService adminUserService)
        {
            _db = db;
            _evaluationService = evaluationService;
            _formBuilderService = formBuilderService;
            _adminUserService = adminUserService;
        }

        [HttpGet]
        public async Task<IActionResult> Dashboard()
        {
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> ShowAllEvaluations()
        {
            var allEvaluations = await _evaluationService.GetAllEvaluationsAsync();
            AdminShowAllEvaluationsViewModel adminShowAllEvaluationsViewModel = new AdminShowAllEvaluationsViewModel
            {
                Evaluations = allEvaluations.Select(e => new EvaluationViewModel
                {
                    Id = e.Id,
                    Title = e.Title,
                    IsPublished = e.IsPublished
                }).ToList() ?? new List<EvaluationViewModel>()
            };

            return View(adminShowAllEvaluationsViewModel);
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

        [HttpGet]
        public async Task<IActionResult> CreateEvaluation()
        {

            
            AdminCreateEvaluationViewmodel adminCreateEvaluationViewmodel = new AdminCreateEvaluationViewmodel
            {
                Modules = _formBuilderService.GetModules(),
                IsPublished = _formBuilderService.CreatePublishCheckbox(),
                StartDate = DateTime.UtcNow.Date,
                EndDate = DateTime.UtcNow.Date,
                CompetenceDomains = _formBuilderService.GetCompetenceDomainsDistinctByName()
            };

            return View(adminCreateEvaluationViewmodel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateEvaluation(AdminCreateEvaluationViewmodel adminCreateEvaluationViewmodel)
        {

            if (!ModelState.IsValid)
            {
                await _formBuilderService.ReseedEvaluationCreateFormAsync(adminCreateEvaluationViewmodel);

                return View(adminCreateEvaluationViewmodel);
            }

            var creationResult = await _evaluationService.CreateEvaluationAsync(adminCreateEvaluationViewmodel);
            if (!creationResult.Succes)
            {
                foreach(var error in creationResult.Errors)
                {
                    ModelState.AddModelError("failedCreation", error);
                }
                await _formBuilderService.ReseedEvaluationCreateFormAsync(adminCreateEvaluationViewmodel);
                return View(adminCreateEvaluationViewmodel);
            }
            return RedirectToAction("Dashboard", "Admin");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateEvaluation(Guid id)
        {
            var evaluation = await _evaluationService.GetAnyEvaluationByIdAsync(id);
            if (evaluation is null) return BadRequest();

            AdminUpdateEvaluationViewModel adminUpdateEvaluationViewModel = new AdminUpdateEvaluationViewModel()
            {
                Id = evaluation.Id,
                Title = evaluation.Title,
                Description = evaluation.Description,
                StartDate = evaluation.StartDate,
                EndDate = evaluation.EndDate,
                IsPublished = _formBuilderService.CreatePublishCheckbox(),
                CompetenceDomains = _formBuilderService.GetCompetenceDomainsDistinctByName(),
                Modules = _formBuilderService.GetModules()
            };

            //seeding data in form
            await _formBuilderService.ReseedEvaluationUpdateFormAsync(adminUpdateEvaluationViewModel, evaluation);

            return View(adminUpdateEvaluationViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateEvaluation(AdminUpdateEvaluationViewModel adminUpdateEvaluationViewModel)
        {
            var existingEvaluation = await _evaluationService.GetAnyEvaluationByIdAsync(adminUpdateEvaluationViewModel.Id);

            if (!ModelState.IsValid)
            {
                if(existingEvaluation is not null)
                {
                    //reseeding data in form
                    await _formBuilderService.ReseedEvaluationUpdateFormAsync(adminUpdateEvaluationViewModel, existingEvaluation);
                }                
                return View(adminUpdateEvaluationViewModel);
            }

            var updateResult = await _evaluationService.UpdateEvaluationAsync(adminUpdateEvaluationViewModel);
            if (!updateResult.Succes)
            {
                foreach(var error in updateResult.Errors)
                {
                    ModelState.AddModelError("updateFailure", error);
                }
                //reseeding data in form
                await _formBuilderService.ReseedEvaluationUpdateFormAsync(adminUpdateEvaluationViewModel, existingEvaluation);
                return View(adminUpdateEvaluationViewModel);
            }

            return RedirectToAction("Dashboard", "Admin");
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

            var existingUser = await _adminUserService.GetByEmailAsync(vm.Username);

            if (existingUser != null)
            {
                ModelState.AddModelError("Username", "Email wordt al gebruikt");
                return View(vm);
            }
           

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

            var existingUser = await _adminUserService.GetByEmailAsync(vm.Username);

            if (existingUser != null && existingUser.Id != vm.Id)
            {
                ModelState.AddModelError("Username", "Email wordt al gebruikt");
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
