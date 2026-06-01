using Howest.SelfEvaluation.Core.Entities;
using Howest.SelfEvaluation.Web.Data;
using Howest.SelfEvaluation.Web.Services.Interfaces;
using Howest.SelfEvaluation.Web.ViewModels;
using Howest.SelfEvaluation.Web.ViewModels.Student;
using Howest.SelfEvaluation.Web.ViewModels.Mentor;
using Howest.SelfEvaluation.Web.ViewModels.Teacher;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
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
        private readonly IViewModelMappingService _mappingService;
        private readonly IOverlayService _overlayService;

        public TeacherController(SelfEvaluationsDbContext db, IEvaluationService evaluationService, IViewModelMappingService mappingService, IOverlayService overlayService)
        {
            _db = db;
            _evaluationService = evaluationService;
            _mappingService = mappingService;
            _overlayService = overlayService;
        }

        //for demo purposes, not final
        public async Task<IActionResult> Dashboard()
        {
            var module = await _db.Modules.FirstOrDefaultAsync();

            if (module == null)
            {
                return View(new TeacherDashboardViewModel
                {
                    Students = new List<TeacherStudentViewModel>()
                });
            }

            var students = await _evaluationService.GetStudentsForModule(module.Id);

            var vm = new TeacherDashboardViewModel
            {
                Students = students.Select(s => new TeacherStudentViewModel
                {
                    Id = s.Id,
                    UserName = s.Username
                }).ToList()
            };

            return View(vm);
        }
        /* public async Task<IActionResult> Dashboard()
         {
             //DEVELOPMENT ONLY since no login system yet
             //TODO: change this to the logged in teacher id (refactor method to use Guid instead of name) once login implemented
             //for now its hardcoded for demo purposes and we didnt get to do login implementation
             BaseViewModel baseViewModel = new() { Name = "test@test.com" };
             //BaseViewModel baseViewModel = new() { Name = "teacher@teacher.com" };
             return View(baseViewModel);
         }*/

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
        public async Task<IActionResult> ShowEvaluationsPerModule(Guid moduleId, Guid studentId)
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
                UserId = studentId
            };
            return View(viewmodel);
        }
        [HttpGet]
        public async Task<IActionResult> ShowStudents(Guid domainId, Guid evaluationId)
        {
            if (domainId == Guid.Empty)
                return RedirectToAction("Index");

            var students = await _evaluationService.GetStudentsForDomainAsync(domainId, evaluationId);

            var vm = new TeacherShowStudentsViewModel
            {
                DomainId = domainId,
                EvaluationId = evaluationId,
                Students = students.Select(s => new StudentListItemViewModel
                {
                    Id = s.Id,
                    Username = s.Username
                }).ToList()
            };

            return View(vm);
        }
        [HttpGet]
        public async Task<IActionResult> ShowStudentCharts(Guid studentId, Guid evaluationId, Guid domainId)
        {
            var scores = await _evaluationService.GetStudentResultsAsync(studentId, evaluationId, domainId);

            var vm = new StudentShowEvaluationViewModel
            {
                UserId = studentId,
                EvaluationId = evaluationId,
                Results = scores.Select(s => new StudentEvaluationResultViewModel
                {
                    CompetenceName = s.Indicator?.Competence?.Name,
                    IndicatorDescription = s.Indicator?.Description,
                    Score = s.NotApplicable ? null : s.Indicator?.ScaleValue,
                    NotApplicable = s.NotApplicable,
                    Comment = s.ExtraInfo
                }).ToList()
            };

            return View("ShowCharts", vm);
        }


        [HttpGet]
        public async Task<IActionResult> ShowDomainsPerEvaluation(Guid evaluationId, Guid teacherId)
        {
            var evaluation = await _evaluationService.GetPublishedEvaluationByIdAsync(evaluationId);

            if (evaluation == null)
            {
                return NotFound();
            }

            TeacherShowDomainsPerEvaluationViewModel teacherShowDomainsPerEvaluationViewModel = new TeacherShowDomainsPerEvaluationViewModel
            {
                Id = evaluationId,
                ModuleId = evaluation.ModuleId,
                Title = evaluation.Title,
                Description = evaluation.Description,
                CompetenceDomains = evaluation.CompetenceDomains?
                                    .Select(c => _mappingService.MapToCompetenceDomainViewModel(c))
                                    .ToList() ?? new(),
                StudentEvaluationScores = evaluation.StudentEvaluationScores?
                                    .Select(e => _mappingService.MapToEvaluationScoreViewModel(e))
                                    .ToList() ?? new(),
                IsPublished = evaluation.IsPublished,
                UserId = teacherId
            };

            return View(teacherShowDomainsPerEvaluationViewModel);
        }
        public async Task<IActionResult> StudentCombinedEvaluations(Guid studentId)
        {
            var evaluations = await _evaluationService.GetEvaluationsForStudent(studentId);

            var vm = new TeacherCombinedEvaluationViewModel
            {
                StudentId = studentId,
                Evaluations = evaluations
            };

            return View(vm);
        }



        public async Task<IActionResult> Overlay(Guid domainId, Guid studentId)
        {
            var vm = await _overlayService.GetOverlayAsync(domainId, studentId);

            if (vm == null)
                return NotFound();

            return View(vm);
        }


        [HttpGet]
        public async Task<IActionResult> OverlaySelector()
        {
            var vm = new TeacherOverlaySelectViewModel
            {
                StudentOptions = await _db.ApplicationUsers
                    .Where(u => u.Role == "Student")
                    .Select(s => new SelectListItem
                    {
                        Value = s.Id.ToString(),
                        Text = s.Firstname + " " + s.Lastname
                    })
                    .ToListAsync(),

                DomainOptions = await _db.CompetenceDomains
                    .Include(d => d.Evaluations)
                    .Select(d => new SelectListItem
                    {
                        Value = d.Id.ToString(),
                        Text = d.Name + " (" +
                               (d.Evaluations.Any()
                                   ? string.Join(",", d.Evaluations.Select(e => e.Title))
                                   : "geen evaluaties") + ")"
                    })
                    .ToListAsync()
            };

            return View(vm);
        }
        [HttpPost]
        public async Task<IActionResult> OverlaySelector(TeacherOverlaySelectViewModel vm)
        {
            vm.StudentOptions = await _db.ApplicationUsers
                .Where(u => u.Role == "Student")
                .Select(s => new SelectListItem
                {
                    Value = s.Id.ToString(),
                    Text = s.Firstname + " " + s.Lastname
                })
                .ToListAsync();

            vm.DomainOptions = await _db.CompetenceDomains
                .Include(d => d.Evaluations)
                .Select(d => new SelectListItem
                {
                    Value = d.Id.ToString(),
                    Text = d.Name + " (" +
                           (d.Evaluations.Any()
                               ? string.Join(",", d.Evaluations.Select(e => e.Title))
                               : "geen evaluaties") + ")"
                })
                .ToListAsync();

            if (!vm.DomainId.HasValue || !vm.StudentId.HasValue)
            {
                ModelState.AddModelError("", "Selecteer een student en een domein");
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

