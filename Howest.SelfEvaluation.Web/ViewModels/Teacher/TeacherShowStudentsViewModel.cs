using Howest.SelfEvaluation.Core.Entities;

namespace Howest.SelfEvaluation.Web.ViewModels.Teacher
{
    public class TeacherShowStudentsViewModel
    {
        public Guid DomainId { get; set; }
        public List<StudentListItemViewModel> Students { get; set; }
        public Guid EvaluationId { get; set; }
    }

    public class TeacherStudentViewModel
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
    }
}