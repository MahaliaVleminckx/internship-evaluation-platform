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
using System.Threading.Tasks;

namespace Howest.SelfEvaluation.Web.Controllers
{
    //For testing purposes this is public
    //TODO: Use authorize attribute once Microsoft Identity implemented, uncomment code below to protect from public
    //[Authorize(Roles = "Teacher, Admin")]
    public class TeacherController : Controller
    {
        private readonly SelfEvaluationsDbContext _db;
        private readonly IEvaluationService _evaluationService;

        public TeacherController(SelfEvaluationsDbContext db, IEvaluationService evaluationService)
        {
            _db = db;
            _evaluationService = evaluationService;
        }


        [HttpGet]
        public async Task<IActionResult> Index(string? username)
        {
            //TODO: change string username to Guid userId once we have a login system or perhaps use a btn for development reasons on home screen
            // with asp-route-Id for ease of use
            //you can get into the index through https://localhost:7140/teacher/Index?username=teacher@teacher.com


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
        [HttpGet]
        public async Task<IActionResult> ShowStudents(Guid domainId)
        {
            if (domainId == Guid.Empty)
                return RedirectToAction("Index");

            var students = await _evaluationService.GetStudentsForDomainAsync(domainId);

            var vm = new TeacherShowStudentsViewModel
            {
                DomainId = domainId,
                Students = students.Select(s => new StudentListItemViewModel
                {
                    Id = s.Id,
                    Username = s.Username
                }).ToList()
            };

            return View(vm);
        }
        [HttpGet]
        public async Task<IActionResult> ShowStudentDetails(Guid studentId, Guid domainId)
        {
            var scores = await _evaluationService.GetStudentResultsForDomainAsync(studentId, domainId);

            var vm = new TeacherShowStudentsDetailsViewModel
            {
                StudentId = studentId,
                DomainId = domainId,
                Results = scores.Select(r => new StudentResultViewModel
                {
                    CompetenceName = r.Indicator?.Competence?.Name,
                    IndicatorDescription = r.Indicator?.Description,
                    Score = r.NotApplicable ? null : r.Indicator.ScaleValue,
                    NotApplicable = r.NotApplicable,
                    Comment = r.ExtraInfo
                }).ToList()
            };

            return View(vm);
        }


        //Voorlopig om overlay te kunnen gebruiken: https://localhost:7140/Teacher/Overlay?domainId=00000000-0000-0000-0000-000000000006&studentId=B7B82198-E824-4E7A-A020-D66C0A292B85
        public async Task<IActionResult> Overlay(Guid domainId, Guid studentId)
        {
            var domain = await _db.CompetenceDomains
                .Include(d => d.Competences)
                .FirstOrDefaultAsync(d => d.Id == domainId);

            if (domain == null)
            {
                return NotFound();
            }
            var student = await _db.ApplicationUsers.FirstOrDefaultAsync(u => u.Id == studentId);

            if (student == null)
            {
                return NotFound();
            }

            var overlayCompetences = new List<OverlayCompetenceViewModel>();

            foreach (var competence in domain.Competences ?? new List<Competence>())
            {

                var studentScore = await _db.EvaluationScores
                    .FirstOrDefaultAsync(s => s.CompetenceId == competence.Id &&
                    s.TargetUserId == studentId &&
                    s.UserId == studentId);

                var mentorScore = await _db.EvaluationScores
                   .FirstOrDefaultAsync(s => s.CompetenceId == competence.Id &&
                   s.TargetUserId == studentId &&
                   s.UserId != studentId);

                var indicatorIds = new List<Guid>();

                if (studentScore?.IndicatorId != null)
                {
                    indicatorIds.Add(studentScore.IndicatorId.Value);
                }

                if (mentorScore?.IndicatorId != null)
                {
                    indicatorIds.Add(mentorScore.IndicatorId.Value);
                }

                var indicators = indicatorIds.Any() ? await _db.Indicators
                    .Where(i => indicatorIds.Contains(i.Id))
                    .ToDictionaryAsync(i => i.Id)
                    : new Dictionary<Guid, Indicator>();

                Indicator? GetIndicator(EvaluationScore? score)
                {
                    if (score?.IndicatorId == null) return null;

                    return indicators.TryGetValue(score.IndicatorId.Value, out var indicator) ? indicator : null;
                }

                var studentIndicator = GetIndicator(studentScore);
                var mentorIndicator = GetIndicator(mentorScore);


                overlayCompetences.Add(new OverlayCompetenceViewModel
                {
                    Name = competence.Name,
                    Description = competence.Description,

                    StudentScore = studentIndicator?.ScaleValueScore,
                    MentorScore = mentorIndicator?.ScaleValueScore,

                    StudentScoreLabel = studentIndicator?.ScaleValue,
                    MentorScoreLabel = mentorIndicator?.ScaleValue,

                    StudentComment = studentScore?.ExtraInfo ?? "",
                    MentorComment = mentorScore?.ExtraInfo ?? ""

                });

            }

            var viewModel = new EvaluationOverlayViewModel
            {
                StudentId = studentId,
                StudentName = $"{student.Firstname} {student.Lastname}",
                OverlayCompetences = overlayCompetences,
            };


            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> OverlaySelector()
        {
            var vm = new TeacherOverlaySelectViewModel
            {
                Students = await _db.ApplicationUsers
                .Where(u => u.Role == "Student")
                .ToListAsync(),

                Evaluations = await _db.Evaluations.ToListAsync(),

                Domains = await _db.CompetenceDomains
                .Include(d => d.Evaluations).AsNoTracking()
                .ToListAsync()
            };
            return View(vm);
        }
        [HttpPost]
        public async Task<IActionResult> OverlaySelector(TeacherOverlaySelectViewModel vm)
        {
            vm.Students = await _db.ApplicationUsers.Where(u => u.Role == "Student").ToListAsync();
            vm.Domains = await _db.CompetenceDomains.ToListAsync();

            if (!vm.DomainId.HasValue || !vm.StudentId.HasValue)
            {
                ModelState.AddModelError("", "Select a student and a domain");
                return View(vm);
            }
            return RedirectToAction(nameof(Overlay), new
            {
                domainId = vm.DomainId,
                studentId = vm.StudentId
            });

        }

    }
}

