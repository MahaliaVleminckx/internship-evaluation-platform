using Howest.SelfEvaluation.Web.ViewModels.Student;

namespace Howest.SelfEvaluation.Web.ViewModels.Teacher
{
    public class TeacherCombinedEvaluationViewModel
    {
        public Guid StudentId { get; set; }
        public List<EvaluationResultGroup> Evaluations { get; set; }
    }

    public class EvaluationResultGroup
    {
        public string EvaluationTitle { get; set; }
        public List<StudentEvaluationResultViewModel> Results { get; set; }
    }
}
