using Howest.SelfEvaluation.Core.Entities;
using Howest.SelfEvaluation.Web.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        //public IActionResult CreateModule()
        //{
        //    return View();
        //}

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

            if (assignedStudentIds != null && assignedStudentIds.Count > 0)
            {
                var students = await _db.ApplicationUsers.Where(u => assignedStudentIds.Contains(u.Id)).ToListAsync();
                foreach (var student in students)
                {
                    //_db.Set<ApplicationUserModule>().Add(new ApplicationUserModule
                    //{
                    //    ApplicationUserId = studentId,
                    //    ModuleId = module.Id
                    //});

                    student.Modules.Add(module);
                }
            }

            await _db.SaveChangesAsync();
            return RedirectToAction("CreateModule");
        }
    }
}
