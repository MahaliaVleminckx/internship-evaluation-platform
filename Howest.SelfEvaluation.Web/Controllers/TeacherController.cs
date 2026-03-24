using Microsoft.AspNetCore.Mvc;

namespace Howest.SelfEvaluation.Web.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
