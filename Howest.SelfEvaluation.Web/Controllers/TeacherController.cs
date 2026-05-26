using Howest.SelfEvaluation.Core.Entities;
using Howest.SelfEvaluation.Web.Data;
using Howest.SelfEvaluation.Web.Services.Interfaces;
using Howest.SelfEvaluation.Web.ViewModels;
using Howest.SelfEvaluation.Web.ViewModels.Teacher;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

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
        public async Task<IActionResult> Index(string username)
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

    }
}

