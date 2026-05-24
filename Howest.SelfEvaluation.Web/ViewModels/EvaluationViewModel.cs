namespace Howest.SelfEvaluation.Web.Models
{
    public class EvaluationViewModel
    {
        public string Title { get; set; }
        public Guid Id { get; set; }
        public bool IsPublished { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
