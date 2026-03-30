namespace Howest.SelfEvaluation.Web.ViewModels
{
    public class StudentEvaluationViewModel
    {
        public Guid EvaluationId { get; set; }
        public List<QuestionAnswerViewModel> Questions { get; set; }
    }

    public class QuestionAnswerViewModel
    {
        public Guid QuestionId { get; set; }   // = IndicatorId
        public string QuestionText { get; set; }
        public string Answer { get; set; }
    }
}
