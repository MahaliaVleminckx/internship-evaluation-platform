using Howest.SelfEvaluation.Core.Entities;
using Howest.SelfEvaluation.Web.Data;
using Howest.SelfEvaluation.Web.Services.Interfaces;
using Howest.SelfEvaluation.Web.ViewModels;
using Howest.SelfEvaluation.Web.ViewModels.Mentor;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Howest.SelfEvaluation.Web.Controllers
{
    //development only:
    //mentor username: mentor@mentor.com

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

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var allEvaluations = await _evaluationService.GetAllPublishedEvaluationsAsync();

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
                .Where(d => d.EvaluationId == evaluationId).ToListAsync();

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

        public async Task<IActionResult> ShowCompetencePerDomain(Guid domainId)
        {
            var domain = await _db.CompetenceDomains
                .Include(d => d.Competences)
                .ThenInclude(c => c.Indicators)
                .FirstOrDefaultAsync(d => d.Id == domainId);

            if (domain == null)
            {
                return NotFound();
            }

            Console.WriteLine($"Competence count: {domain.Competences.Count}");

            foreach (var c in domain.Competences)
            {
                Console.WriteLine($"Competence {c.Name} has {c.Indicators.Count} indicators");
            }   

            var evaluation = await _db.Evaluations.FindAsync(domain.EvaluationId);
            if (evaluation == null)
            {
                return NotFound();
            }


            var viewModel = new MentorCompetencesViewModel
            {
                EvaluationId = evaluation.Id,
                DomainId = domain.Id,
                DomainName = domain.Name,
                Title = evaluation.Title,
                Competences = domain.Competences.Select(c => new CompetenceViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Description = c.Description,
                    Indicators = c.Indicators.ToList()
                }).ToList()
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SubmitCompetenceEvaluation(MentorCompetencesViewModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData["ErrorMessage"] = "Er is iets fout gegaan bij het opslaan";
                return View(model);
            }
            var userId = Guid.Parse("00000000-0000-0000-0000-000000000010");
            foreach (var competence in model.Competences)
            {
                var competenceExists = await _db.Competences.AnyAsync(c => c.Id == competence.Id);
                if (!competenceExists)
                {
                    continue;
                }
                    var score = new EvaluationScore
                    {
                        EvaluationId = model.EvaluationId,
                        CompetenceId = competence.Id,
                        IndicatorId = competence.SelectedIndicatorId,
                        NotApplicable = !competence.SelectedIndicatorId.HasValue,
                        ExtraInfo = competence.Comment,
                        UserId = userId
                    };
                    _db.EvaluationScores.Add(score);
            }

            await _db.SaveChangesAsync();
            TempData["SuccessMessage"] = "Evaluatie succesvol opgeslagen!";
            return RedirectToAction("ShowCompetencePerDomain", new { domainId = model.DomainId});

        }

        [HttpGet]
        public async Task<IActionResult> ShowStudents()
        {
            var allStudents = await _evaluationService.GetAllStudentsAsync();

            MentorShowStudentsViewModel mentorShowStudentsViewModel = new MentorShowStudentsViewModel
            {
                Students = allStudents.Select(student => new StudentViewModel
                {
                    UserId = student.Id,
                    UserName = student.Username
                })
            };

            return View(mentorShowStudentsViewModel);
        }

        [HttpGet]
        public async Task<IActionResult> ShowStudent(int studentId)
        {
            return View();
        }
    }
}
