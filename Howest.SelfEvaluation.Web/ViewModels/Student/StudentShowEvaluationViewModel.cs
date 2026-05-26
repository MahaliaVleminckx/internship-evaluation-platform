namespace Howest.SelfEvaluation.Web.ViewModels.Student
{
    public class StudentShowEvaluationViewModel
    {
        public Guid EvaluationId { get; set; }
        public Guid UserId { get; set; }

        public List<StudentEvaluationResultViewModel> Results { get; set; } = new();
    }
}