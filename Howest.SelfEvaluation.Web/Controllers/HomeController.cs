using Microsoft.AspNetCore.Mvc;

namespace Howest.SelfEvaluation.Web.Controllers
{
    public class HomeController : Controller
    {
        //TODO: login screen here
        public IActionResult Index()
        {
            return View();
        }
    }
}
