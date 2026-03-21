using Howest.SelfEvaluation.Core.Entities;
using Howest.SelfEvaluation.Web.Data;
using Howest.SelfEvaluation.Web.Models;
using Howest.SelfEvaluation.Web.Services.Interfaces;
using Howest.SelfEvaluation.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace Howest.SelfEvaluation.Web.Controllers
{
    public class EvaluationsController : Controller
    {
        private readonly SelfEvaluationsContext _db;
        private readonly IEvaluationService _evaluationService;

        public EvaluationsController(SelfEvaluationsContext db, IEvaluationService evaluationService)
        {
            _db = db;
            _evaluationService = evaluationService;
        }

        public async Task<IActionResult> Index(string username)
        {
            //TODO: change string username to Guid userId once we have a login system or perhaps use a btn for development reasons on home screen
            // with asp-route-Id for ease of use

            //todo: move to service
            var user = await _evaluationService.GetUserByUsernameAsync(username);

            if (user == null)
            {
                return NotFound();
            }

            EvaluationsIndexViewModel evaluationsIndexViewModel = new EvaluationsIndexViewModel
            {
                User = user,
            };


            return View(evaluationsIndexViewModel);
        }

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
                Module = module
            };

            return View(evaluationsShowEvaluationsPerModuleViewModel);
        }

        public async Task<IActionResult> ShowDomainsPerEvaluation(Guid evaluationId)
        {
            var evaluation = await _evaluationService.GetEvaluationByIdAsync(evaluationId);

            if(evaluation == null)
            {
                return NotFound();
            }

            EvaluationsShowDomainsPerEvaluationViewModel evaluationsShowDomainsPerEvaluationViewModel = new EvaluationsShowDomainsPerEvaluationViewModel
            {
                Evaluation = evaluation
            };


            return View(evaluationsShowDomainsPerEvaluationViewModel);
        }


    }
}
