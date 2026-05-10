using Howest.SelfEvaluation.Core.Entities;

namespace Howest.SelfEvaluation.Web.ViewModels.Teacher
{
    public class TeacherStudentsViewModel
    {
        public Guid DomainId { get; set; }
        public List<ApplicationUser> Students { get; set; } = new();
    }
}