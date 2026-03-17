using Howest.SelfEvaluation.Core.Entities;
using Howest.SelfEvaluation.Web.Data;
using Howest.SelfEvaluation.Web.Models;
using Howest.SelfEvaluation.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
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

        //TODO: student evaluations implementation
        public async Task<IActionResult> Index(string username)
        {
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
    }
}
