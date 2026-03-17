using Howest.SelfEvaluation.Web.Data;
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
        //public async Task<IActionResult> Index(int id)
        //{
        //    //todo: move to service
        //    var user = _db
        //        .ApplicationUsers
        //        .SingleOrDefaultAsync(u=>u.Id == id);


        //    return View();
        //}
    }
}
