using Howest.SelfEvaluation.Core.Entities;
using Howest.SelfEvaluation.Web.Data;
using Microsoft.AspNetCore.Mvc;
//using System.Reflection;

namespace Howest.SelfEvaluation.Web.Controllers
{
    public class AdminController : Controller
    {
        private readonly SelfEvaluationsContext _db;

        public AdminController (SelfEvaluationsContext db)
        {
            _db = db;
        }

        [HttpGet]

        public IActionResult CreateModule()
        {
            return View();
        }

        [HttpPost]

        public IActionResult CreateModule(string name, string description, Guid? ownerId)
        {
            var module = new Module
            {
                Id = Guid.NewGuid(),
                Name = name,
                Description = description,
                OwnerId = ownerId,
                Created = DateTime.Now
            };

            _db.Modules.Add(module);
            _db.SaveChanges();
            return RedirectToAction("CreateModule");
        }
    }
}
