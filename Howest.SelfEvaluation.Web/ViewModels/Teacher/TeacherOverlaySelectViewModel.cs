using Howest.SelfEvaluation.Core.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Howest.SelfEvaluation.Web.ViewModels.Teacher
{
    public class TeacherOverlaySelectViewModel
    {

        public Guid? StudentId { get; set; }
        public Guid? DomainId { get; set; }

        public List<SelectListItem> StudentOptions { get; set; } = new();
        public List<SelectListItem> DomainOptions { get; set; } = new();
    }
}
