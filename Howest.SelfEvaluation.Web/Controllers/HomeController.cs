using Microsoft.AspNetCore.Mvc;

namespace Howest.SelfEvaluation.Web.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
