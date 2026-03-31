using Howest.SelfEvaluation.Core.Entities;
using Howest.SelfEvaluation.Web.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Providers;


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

        public async Task<IActionResult> CreateModule()
        {
            var students = await _db.ApplicationUsers.Where(u => u.Role == "Student").ToListAsync();

            ViewBag.Students = students;

            var teachers = await _db.ApplicationUsers.Where(u => u.Role == "Teacher").ToListAsync();

            ViewBag.Teachers = teachers;


            return View();

        }

        [HttpPost]

        public async Task<IActionResult> CreateModule(string name, string description, Guid? ownerId, List<Guid> assignedStudentIds)
        {
            if (string.IsNullOrEmpty(name) || ownerId == null)
            {
                return BadRequest("Naam en teacher zijn verplicht");
            }
           
            var module = new Module
            {
                Id = Guid.NewGuid(),
                Name = name,
                Description = description,
                OwnerId = ownerId,
                Created = DateTime.Now
            };

            _db.Modules.Add(module);

            _db.Set<ApplicationUserModule>().Add(new ApplicationUserModule
            {
                ApplicationUserId = ownerId.Value,
                ModuleId = module.Id
            });

            if (assignedStudentIds != null && assignedStudentIds.Count > 0)
            {
                foreach (var studentId in assignedStudentIds)
                {
                    _db.Set<ApplicationUserModule>().Add(new ApplicationUserModule
                    {
                        ApplicationUserId = studentId,
                        ModuleId = module.Id
                    });
                }
            }

            await _db.SaveChangesAsync();
            return RedirectToAction("CreateModule");
        }
    }
}
