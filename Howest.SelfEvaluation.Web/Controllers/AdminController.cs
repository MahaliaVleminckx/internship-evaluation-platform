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
                IsPublished = _formBuilderService.CreatePublisherCheckbox(),
                StartDate = DateTime.UtcNow.Date,
                EndDate = DateTime.UtcNow.Date,
                CompetenceDomains = _formBuilderService.GetCompetenceDomainsDistinctByName()
            };

            return View(adminCreateEvaluationViewmodel);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> CreateEvaluation(AdminCreateEvaluationViewmodel adminCreateEvaluationViewmodel)
        {
            if(!await _evaluationService.DoesModuleIdExistAsync(adminCreateEvaluationViewmodel.ModuleId))
            {
                ModelState.AddModelError("moduleNotFound", $"No module with id {adminCreateEvaluationViewmodel.ModuleId} was found.");
            }
            if (!ModelState.IsValid)
            {
                adminCreateEvaluationViewmodel.Modules = _formBuilderService.GetModules();
                adminCreateEvaluationViewmodel.IsPublished = _formBuilderService.CreatePublisherCheckbox();
                adminCreateEvaluationViewmodel.StartDate = DateTime.UtcNow.Date;
                adminCreateEvaluationViewmodel.EndDate = DateTime.UtcNow.Date;
                adminCreateEvaluationViewmodel.CompetenceDomains = _formBuilderService.GetCompetenceDomainsDistinctByName();

                return View(adminCreateEvaluationViewmodel);
            }

            var newEvaluation = new Evaluation
            {
                Id = Guid.NewGuid(),
                Created = DateTime.UtcNow,
                ModuleId = adminCreateEvaluationViewmodel.ModuleId,
                Title = adminCreateEvaluationViewmodel.Title,
                Description = adminCreateEvaluationViewmodel.Description,
                StartDate = adminCreateEvaluationViewmodel.StartDate,
                EndDate = adminCreateEvaluationViewmodel.EndDate,
                IsPublished = adminCreateEvaluationViewmodel.IsPublished.IsSelected,
                //todo; add in view for each of these
                StudentEvaluationScores = new List<EvaluationScore> { }
            };

            //todo?: restructure database with competencedomain(id - name) then link in new table CompetenceDomainsEvalutions?

            //linking of competenceDomains and evaluation
            List<CompetenceDomain> linkCompetenceDomainsToEvaluation = new List<CompetenceDomain>();
            var selectedCompetenceDomains = adminCreateEvaluationViewmodel
                .CompetenceDomains
                .Where(c => c.IsSelected == true)
                .ToList();

            for(int i = 0; i < selectedCompetenceDomains.Count(); i++)
            {
                var competenceDomain = selectedCompetenceDomains[i];

                linkCompetenceDomainsToEvaluation.Add(new CompetenceDomain
                {
                    Id = Guid.NewGuid(),
                    Created = DateTime.UtcNow,
                    EvaluationId = newEvaluation.Id,
                    Name = competenceDomain.Text
                });
            }

            await _db.CompetenceDomains.AddRangeAsync(linkCompetenceDomainsToEvaluation);
            await _db.Evaluations.AddAsync(newEvaluation);
            await _db.SaveChangesAsync();
            return RedirectToAction("Dashboard", "Admin");
        }

    }
}
