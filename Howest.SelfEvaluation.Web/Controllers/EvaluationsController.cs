using Howest.SelfEvaluation.Core.Entities;
using Howest.SelfEvaluation.Web.Data;
using Howest.SelfEvaluation.Web.Models;
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
                .FirstOrDefaultAsync();

            if (user == null)
            {
                return NotFound();
            }


            return View();
        }
    }
}
