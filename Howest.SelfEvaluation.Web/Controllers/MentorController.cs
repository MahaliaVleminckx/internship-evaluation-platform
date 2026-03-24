using Howest.SelfEvaluation.Web.Data;
using Howest.SelfEvaluation.Web.Services.Interfaces;
using Howest.SelfEvaluation.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Howest.SelfEvaluation.Web.Controllers
{
    //For testing purposes this is public
    //TODO: Use authorize attribute once Microsoft Identity implemented, uncomment code below to protect from public
    //[Authorize(Roles = "Mentor, Admin")]
    public class MentorController : Controller
    {
        private readonly SelfEvaluationsContext _db;
        private readonly IEvaluationService _evaluationService;

        public MentorController(SelfEvaluationsContext db, IEvaluationService evaluationService)
        {
            _db = db;
            _evaluationService = evaluationService;
        }

        public async Task<IActionResult> Index()
        {
            var allEvaluations = await _evaluationService.GetAllEvaluationsAsync();

            var mentorIndexViewModel = new MentorIndexViewModel
            {
                Evaluations = allEvaluations
            };

            return View(mentorIndexViewModel);
        }
    }
}
