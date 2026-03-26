using Howest.SelfEvaluation.Core.Entities;
using Howest.SelfEvaluation.Web.Data;
using Howest.SelfEvaluation.Web.Services.Interfaces;
using Howest.SelfEvaluation.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; 

namespace Howest.SelfEvaluation.Web.Controllers
{
    //For testing purposes this is public
    //TODO: Use authorize attribute once Microsoft Identity implemented, uncomment code below to protect from public
    //[Authorize(Roles = "Mentor")]
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

        public async Task<IActionResult> ShowDomainsPerEvaluation(Guid evaluationId)
        {
            var evaluation = await _db.Evaluations.FindAsync(evaluationId);

            if (evaluation == null)
            {
                return NotFound();
            }

            var domains = await _db.CompetenceDomains
                .Where(d => d.EvaluationId == evaluationId) .ToListAsync();

            var viewModel = new MentorEvaluationDomainsViewModel
            {
                EvaluationId = evaluation.Id,
                Title = evaluation.Title,
                IsPublished = evaluation.IsPublished,
                CompetenceDomains = domains,
                UserId = Guid.NewGuid() //Temporary for testing purposes 
            };

            
            return View(viewModel);
        }

        public async Task<IActionResult> ShowCompetencePerDomain (Guid domainId)
        {
            var domain = await _db.CompetenceDomains
                .Include(d => d.Competences)
                .ThenInclude(c => c.Indicators)
                .FirstOrDefaultAsync(d => d.Id == domainId);

            if (domain == null)
            {
                return NotFound();
            }

            var viewModel = new MentorCompetencesViewModel
            {
                DomainId = domain.Id,
                DomainName = domain.Name,
                Competences = domain.Competences.ToList()
            };

            return View(viewModel);
        }
    }
}
