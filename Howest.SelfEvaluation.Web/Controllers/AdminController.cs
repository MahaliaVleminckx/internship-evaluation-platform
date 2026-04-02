using Howest.SelfEvaluation.Core.Entities;
using Howest.SelfEvaluation.Web.Data;
using Howest.SelfEvaluation.Web.ViewModels;
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
            var vm = new CreateModuleViewModel
            {
                Students = await _db.ApplicationUsers.Where(u => u.Role == "Student").ToListAsync(),
                Teachers = await _db.ApplicationUsers.Where(u => u.Role == "Teacher").ToListAsync()
            };
            return View(vm);
        }

        [HttpPost]

        public async Task<IActionResult> CreateModule(CreateModuleViewModel vm)
        {
            if (!ModelState.IsValid || vm.OwnerId == null)
            {
                return View(vm);
            }
            var module = new Module
            {
                Id = Guid.NewGuid(),
                Name = vm.Name,
                Description = vm.Description,
                OwnerId = vm.OwnerId,
                Created = DateTime.Now
            };

            _db.Modules.Add(module);

            _db.Set<ApplicationUserModule>().Add(new ApplicationUserModule
            {
                ApplicationUserId = vm.OwnerId.Value,
                ModuleId = module.Id
            });

            foreach (var studentId in vm.AssignedStudentIds)
            {
                _db.Set<ApplicationUserModule>().Add(new ApplicationUserModule
                {
                    ApplicationUserId = studentId,
                    ModuleId = module.Id
                });
            }


            await _db.SaveChangesAsync();
            return RedirectToAction("CreateModule");
        }

    }
}
