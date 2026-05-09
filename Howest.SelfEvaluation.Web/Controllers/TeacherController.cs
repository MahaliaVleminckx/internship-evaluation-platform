using Howest.SelfEvaluation.Core.Entities;
using Howest.SelfEvaluation.Web.Data;
using Howest.SelfEvaluation.Web.Services.Interfaces;
using Howest.SelfEvaluation.Web.ViewModels;
using Howest.SelfEvaluation.Web.ViewModels.Teacher;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Howest.SelfEvaluation.Web.ViewModels.Mentor;
using NuGet.ProjectModel;

namespace Howest.SelfEvaluation.Web.Controllers
{
    //For testing purposes this is public
    //TODO: Use authorize attribute once Microsoft Identity implemented, uncomment code below to protect from public
    //[Authorize(Roles = "Teacher, Admin")]
    public class TeacherController : Controller
    {
        private readonly SelfEvaluationsContext _db;
        private readonly IEvaluationService _evaluationService;

        public TeacherController(SelfEvaluationsContext db, IEvaluationService evaluationService)
        {
            _db = db;
            _evaluationService = evaluationService;
        }


        [HttpGet]
        public async Task<IActionResult> Index(string? username)
        {
            //TODO: change string username to Guid userId once we have a login system or perhaps use a btn for development reasons on home screen
            // with asp-route-Id for ease of use
            //you can get into the index through https://localhost:7140/Teacher/Index?username=teacher@test.com


            if (string.IsNullOrEmpty(username))
            {
                return BadRequest("Username is required");
            }

            var user = await _db.ApplicationUsers
                .Include(u => u.Modules)
                .ThenInclude(m => m.Evaluations)
                .Include(u => u.OwnerModules)
                .ThenInclude(m => m.Evaluations)
                .FirstOrDefaultAsync(u => u.Username == username);

            var allModules = user.Modules
              .Concat(user.OwnerModules)
              .Distinct().ToList();


            if (user == null)
            {
                return NotFound();
            }

            TeacherIndexViewModel viewModel = new TeacherIndexViewModel
            {
                UserId = user.Id,
                Username = user.Username,
                Role = user.Role,
                Modules = allModules,
                OwnerModules = user.OwnerModules,
                TeacherEvaluationScores = user.StudentEvaluationScores
            };

            return View(viewModel);

        }


        [HttpGet]
        public async Task<IActionResult> ShowEvaluationsPerModule(Guid moduleId, Guid userId)
        {
            var module = await _db.Modules.Include(m => m.Evaluations).FirstOrDefaultAsync(m => m.Id == moduleId);

            if (module == null)
            {
                return NotFound();
            }

            var viewmodel = new TeacherShowEvaluationsPerModuleViewModel
            {
                ModuleId = module.Id,
                ModuleName = module.Name,
                ModuleDescription = module.Description,
                Evaluations = module.Evaluations.ToList(),
                UserId = userId
            };
            return View(viewmodel);
        }

        //Voorlopig om overlay te kunnen gebruiken: https://localhost:7140/Teacher/Overlay?domainId=00000000-0000-0000-0000-000000000006&studentId=00000000-0000-0000-0000-000000000001
        public async Task<IActionResult> Overlay(Guid domainId, Guid studentId)
        {
            var domain = await _db.CompetenceDomains
                .Include(d => d.Competences)
                .FirstOrDefaultAsync (d => d.Id == domainId);

            if (domain == null)
            {
                return NotFound();
            }

            var overlayCompetences = new List<OverlayCompetenceViewModel>();

            foreach (var competence in domain.Competences)
            {
                var scores = await _db.EvaluationScores
                    .Where(s => s.CompetenceId == competence.Id && s.TargetUserId == studentId)
                    .ToListAsync();

                var indicatorIds = scores
                    .Where(s => s.IndicatorId != null)
                    .Select(s => s.IndicatorId!.Value)
                    .ToList();

                var indicators = await _db.Indicators
                    .Where(i => indicatorIds.Contains(i.Id))
                    .ToDictionaryAsync(i => i.Id);

                var studentScore = scores.FirstOrDefault(s => s.UserId == studentId);
                var mentorScore = scores.FirstOrDefault(s => s.UserId != studentId);

                var studentIndicator = studentScore?.IndicatorId != null && indicators.ContainsKey(studentScore.IndicatorId.Value)
                    ? indicators[studentScore.IndicatorId.Value] : null;
                var mentorIndicator = mentorScore?.IndicatorId != null && indicators.ContainsKey(mentorScore.IndicatorId.Value)
                     ? indicators[mentorScore.IndicatorId.Value] : null;



                overlayCompetences.Add(new OverlayCompetenceViewModel
                {
                    Name = competence.Name,
                    Description = competence.Description,


                   StudentScore = studentIndicator?.ScaleValueScore,
                   MentorScore = mentorIndicator?.ScaleValueScore,


                    StudentComment = studentScore?.ExtraInfo,
                    MentorComment = mentorScore?.ExtraInfo

                });

            }

            var viewModel = new EvaluationOverlayViewModel
            {
                StudentId = studentId,
                StudentName = "Temporary Test Name",
                OverlayCompetences = overlayCompetences,
            };
            

            return View(viewModel);
        }

    }
}

