using Microsoft.AspNetCore.Mvc;

namespace Howest.SelfEvaluation.Web.Controllers
{
    public class AccountController : Controller
    {
        //maybe move this to a separate account area once we implement Microsoft Identity
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
    }
}
