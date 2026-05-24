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

        //for demo purposes, not final
        public async Task<IActionResult> Dashboard()
        {
            //DEVELOPMENT ONLY since no login system yet
            //TODO: change this to the logged in teacher id (refactor method to use Guid instead of name) once login implemented
            //for now its hardcoded for demo purposes and we didnt get to do login implementation
            BaseViewModel baseViewModel = new() { Name = "teacher@teacher.com" };
            return View(baseViewModel);
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
    }
}

