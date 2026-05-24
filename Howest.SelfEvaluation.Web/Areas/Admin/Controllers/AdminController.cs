using Howest.SelfEvaluation.Core.Entities;
using Howest.SelfEvaluation.Web.Areas.Admin.ViewModels.Admin;
using Howest.SelfEvaluation.Web.Data;
using Howest.SelfEvaluation.Web.Models;
using Howest.SelfEvaluation.Web.Services.Interfaces;
using Howest.SelfEvaluation.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using NuGet.Protocol.Providers;
using NuGet.Versioning;


namespace Howest.SelfEvaluation.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        private readonly SelfEvaluationsDbContext _db;
        private readonly IEvaluationService _evaluationService;
        private readonly IFormBuilderService _formBuilderService;

        public AdminController(SelfEvaluationsDbContext db, IEvaluationService evaluationService, IFormBuilderService formBuilderService)
        {
            _db = db;
            _evaluationService = evaluationService;
            _formBuilderService = formBuilderService;
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
            return RedirectToAction("CreateModule", new { Area = "Admin" });
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
            return RedirectToAction("Dashboard", "Admin", new { Area = "Admin" });
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

            return RedirectToAction("Dashboard", "Admin", new { Area = "Admin" });
        }


    }
}
