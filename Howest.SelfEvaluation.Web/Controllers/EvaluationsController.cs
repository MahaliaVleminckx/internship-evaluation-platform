using Howest.SelfEvaluation.Core.Entities;
using Howest.SelfEvaluation.Web.Data;
using Howest.SelfEvaluation.Web.Models;
using Howest.SelfEvaluation.Web.Services.Interfaces;
using Howest.SelfEvaluation.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;


namespace Howest.SelfEvaluation.Web.Controllers
{
    //preparation for Microsoft Identity, this controller is public for everyone, other controllers need authorization
    //need to app.UseAuthorization() in program.cs once implemented for this to work
    [AllowAnonymous]
    public class EvaluationsController : Controller
    {
        private readonly SelfEvaluationsDbContext _db;
        private readonly IEvaluationService _evaluationService;
        private readonly IViewModelMappingService _viewModelMappingService;

        public EvaluationsController(SelfEvaluationsDbContext db, IEvaluationService evaluationService, IViewModelMappingService viewModelMappingService)
        {
            _db = db;
            _evaluationService = evaluationService;
            _viewModelMappingService = viewModelMappingService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string username)
        {
            //TODO: change string username to Guid userId once we have a login system or perhaps use a btn for development reasons on home screen
            // with asp-route-Id for ease of use
            var user = await _evaluationService.GetUserByUsernameAsync(username);

            if (user == null)
            {
                return NotFound();
            }

            EvaluationsIndexViewModel evaluationsIndexViewModel = new EvaluationsIndexViewModel
            {
                UserId = user.Id,
                Username = user.Username,
                Role = user.Role,
                Modules = user.Modules.Select(m => _viewModelMappingService.MapToModuleViewModel(m)).ToList(),
                OwnerModules = user.OwnerModules.Select(om => _viewModelMappingService.MapToModuleViewModel(om)).ToList(),
                //StudentEvaluationScores = user.StudentEvaluationScores
            };
            
            return View(evaluationsIndexViewModel);
        }

        [HttpGet]
        public async Task<IActionResult> ShowEvaluationsPerModule(Guid moduleId, Guid userId)
        {
            var module = await _evaluationService.GetModuleByIdAsync(moduleId);
            var user = await _evaluationService.GetUserByIdAsync(userId);

            if (module == null || user == null)
            {
                return NotFound();
            }

            EvaluationsShowEvaluationsPerModuleViewModel evaluationsShowEvaluationsPerModuleViewModel = new EvaluationsShowEvaluationsPerModuleViewModel
            {
                Id= moduleId,
                Name = module.Name,
                Description = module.Description,
                //ApplicationUsers = module.ApplicationUsers,
                Evaluations = module.Evaluations.Select(e => _viewModelMappingService.MapToEvaluationViewModel(e)).ToList(),
                //Owner = module.Owner,
                OwnerId = module.OwnerId,
                UserId = userId
            };

            return View(evaluationsShowEvaluationsPerModuleViewModel);
        }

        [HttpGet]
        public async Task<IActionResult> ShowDomainsPerEvaluation(Guid evaluationId, Guid userId)
        {
            var evaluation = await _evaluationService.GetPublishedEvaluationByIdAsync(evaluationId);

            if(evaluation == null)
            {
                return NotFound();
            }

            EvaluationsShowDomainsPerEvaluationViewModel evaluationsShowDomainsPerEvaluationViewModel = new EvaluationsShowDomainsPerEvaluationViewModel
            {
                Id = evaluationId,
                ModuleId = evaluation.ModuleId,
                Title = evaluation.Title,
                Description = evaluation.Description,
                CompetenceDomains = evaluation.CompetenceDomains.Select(c => _viewModelMappingService.MapToCompetenceDomainViewModel(c)).ToList(),
                //StudentEvaluationScores = evaluation.StudentEvaluationScores,
                IsPublished = evaluation.IsPublished,
                UserId = userId
            };

            return View(evaluationsShowDomainsPerEvaluationViewModel);
        }


    }
}
