using Howest.SelfEvaluation.Core.Entities;
using Howest.SelfEvaluation.Core.Enums;
using Howest.SelfEvaluation.Web.Data;
using Howest.SelfEvaluation.Web.Services.Interfaces;
using Howest.SelfEvaluation.Web.ViewModels;
using Howest.SelfEvaluation.Web.ViewModels.Mentor;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace Howest.SelfEvaluation.Web.Controllers
{
    //development only:
    //mentor username: mentor@mentor.com

    //For testing purposes this is public
    //TODO: Use authorize attribute once Microsoft Identity implemented, uncomment code below to protect from public
    //[Authorize(Roles = "Mentor, Admin")]
    public class MentorController : Controller
    {
        private readonly SelfEvaluationsDbContext _db;
        private readonly IEvaluationService _evaluationService;

        public MentorController(SelfEvaluationsDbContext db, IEvaluationService evaluationService)
        {
            _db = db;
            _evaluationService = evaluationService;
        }

        

        [HttpGet]
        public async Task<IActionResult> Index(Guid studentId)
        {
            var allEvaluations = await _evaluationService.GetAllPublishedEvaluationsAsync();

            var mentorIndexViewModel = new MentorIndexViewModel
            {
                Evaluations = allEvaluations,
                StudentId = studentId
            };

            return View(mentorIndexViewModel);
        }

        //for demo purposes, not final
        [HttpGet]
        public async Task<IActionResult> Dashboard()
        {
            //DEVELOPMENT ONLY since no login system yet
            Guid mentorId = Guid.Parse("00000000-0000-0000-0000-000000000002");
            BaseViewModel baseViewModel = new() { Id = mentorId };
            return View(baseViewModel);
        }

        public async Task<IActionResult> ShowDomainsPerEvaluation(Guid evaluationId, Guid studentId)
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
                StudentId = studentId
            };


            return View(viewModel);
        }

        public async Task<IActionResult> ShowCompetencePerDomain(Guid domainId, Guid studentId)
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
                }).ToList(),
                StudentId = studentId
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
            var sessionMentorId= HttpContext.Session.Get("mentorId");
            var sessionMentorIdString = Encoding.UTF8.GetString(sessionMentorId);
            var mentorId = Guid.Parse(sessionMentorIdString);
            var studentId = model.StudentId;

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
                        UserId = mentorId,
                        TargetUserId = studentId,
                    };
                    _db.EvaluationScores.Add(score);
            }

            await _db.SaveChangesAsync();
            TempData["SuccessMessage"] = "Evaluatie succesvol opgeslagen!";
            return RedirectToAction("ShowCompetencePerDomain", new { domainId = model.DomainId});

        }

        //no real way yet to get the mentorId from the logged in user. For now add this to the url as workaround
        //testmentor1 GUID: 00000000-0000-0000-0000-000000000002
        //testmentor2 GUID: 00000000-0000-0000-0000-000000000003
        [HttpGet]
        public async Task<IActionResult> ShowStudents(Guid mentorId)
        {
            var mentor = await _evaluationService.GetUserByIdAsync(mentorId);

            //role check here but may chance when we add identity
            if(mentor== null || mentor.Role != RoleTypes.Mentor.ToString())
            {
                //temporal notfound for testing purposes, need to add custom errror message
                return NotFound();
            }

            //I stored the mentorId in the session as a temoporal work around. Once we have Identity and login system
            //implemented we need to change this
            HttpContext.Session.SetString("mentorId", mentorId.ToString());

            var allStudents = await _evaluationService.GetAllStudentsForMentorAsync(mentorId);

            MentorShowStudentsViewModel mentorShowStudentsViewModel = new MentorShowStudentsViewModel
            {
                Students = allStudents.Select(student => new StudentViewModel
                {
                    UserId = student.Id,
                    UserName = student.Username,
                    Firstname = student.Firstname,
                    Lastname = student.Lastname
                })
            };

            return View(mentorShowStudentsViewModel);
        }
    }
}
