using Howest.SelfEvaluation.Core.Entities;

namespace Howest.SelfEvaluation.Web.ViewModels.Teacher
{
    public class TeacherShowStudentsViewModel
    {
        public Guid DomainId { get; set; }
        public List<StudentListItemViewModel> Students { get; set; } = new();
    }
}