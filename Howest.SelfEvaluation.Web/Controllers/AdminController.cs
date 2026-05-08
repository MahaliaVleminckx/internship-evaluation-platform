using Howest.SelfEvaluation.Core.Entities;
using Howest.SelfEvaluation.Web.Data;
using Howest.SelfEvaluation.Web.Models;
using Howest.SelfEvaluation.Web.Services.Interfaces;
using Howest.SelfEvaluation.Web.ViewModels;
using Howest.SelfEvaluation.Web.ViewModels.Admin;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Providers;


namespace Howest.SelfEvaluation.Web.Controllers
{
    public class AdminController : Controller
    {
        private readonly SelfEvaluationsContext _db;
        private readonly IEvaluationService _evaluationService;

        public AdminController(SelfEvaluationsContext db, IEvaluationService evaluationService)
        {
            _db = db;
            _evaluationService = evaluationService;
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
                //TODO move to FormBuilderService             
                Modules = await _db.Modules.Select(m => new SelectListItem
                {
                    Value = m.Id.ToString(),
                    Text = m.Name,
                }).ToListAsync()
            };
            return View(adminCreateEvaluationViewmodel);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> CreateEvaluation(AdminCreateEvaluationViewmodel adminCreateEvaluationViewmodel)
        {
            if(await _evaluationService.DoesModuleIdExistAsync(adminCreateEvaluationViewmodel.ModuleId))
            {
                ModelState.AddModelError("moduleNotFound", $"No module with id {adminCreateEvaluationViewmodel.ModuleId} was found.");
            }
            if (!ModelState.IsValid) return View(adminCreateEvaluationViewmodel);

            var newEvaluation = new Evaluation
            {
                Id = Guid.NewGuid(),
                Created = DateTime.UtcNow,
                ModuleId = adminCreateEvaluationViewmodel.ModuleId,
                Title = adminCreateEvaluationViewmodel.Title,
                Description = adminCreateEvaluationViewmodel.Description,
                //todo; add in view for each of these
                StartDate = adminCreateEvaluationViewmodel.StartDate,
                EndDate = adminCreateEvaluationViewmodel.EndDate,
                CompetenceDomains = new List<CompetenceDomain> { },
                IsPublished = false,
                StudentEvaluationScores = new List<EvaluationScore> { }

            };

            _db.Evaluations.Add(newEvaluation);
            await _db.SaveChangesAsync();
            return RedirectToAction("Dashboard", "Admin");
        }

    }
}
