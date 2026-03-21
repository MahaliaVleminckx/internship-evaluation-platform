using Howest.SelfEvaluation.Core.Entities;
using Howest.SelfEvaluation.Web.Data;
using Howest.SelfEvaluation.Web.Models;
using Howest.SelfEvaluation.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace Howest.SelfEvaluation.Web.Controllers
{
    public class EvaluationsController : Controller
    {
        private readonly SelfEvaluationsContext _db;

        public EvaluationsController(SelfEvaluationsContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index(string username)
        {
            //TODO: change string username to Guid userId once we have a login system or perhaps use a btn for development reasons on home screen
            // with asp-route-Id for ease of use

            //todo: move to service
            var user = await _db
                .ApplicationUsers
                .Where(u => u.Username == username)
                .Include(u=>u.Modules)
                .ThenInclude(m=>m.Evaluations)
                .FirstOrDefaultAsync();

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
            var module = await _db
                .Modules
                .Where(m => m.Id == moduleId)
                .Include(m => m.Evaluations)
                .FirstOrDefaultAsync();

            var user = await _db
                .ApplicationUsers
                .Where(u => u.Id == userId)
                .Include(u => u.Modules)
                .ThenInclude(m => m.Evaluations)
                .FirstOrDefaultAsync();

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

        public IActionResult ShowDomainsPerEvaluation()
        {
            return View();
        }




    }
}
