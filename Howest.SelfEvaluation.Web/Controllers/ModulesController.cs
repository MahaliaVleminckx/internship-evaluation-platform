using Microsoft.AspNetCore.Mvc;

namespace Howest.SelfEvaluation.Web.Controllers
{
    public class ModulesController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
