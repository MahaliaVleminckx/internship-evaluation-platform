namespace Howest.SelfEvaluation.Web.ViewModels.Teacher
{
    public class OverlayCompetenceViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<OverlayEvaluationComparisonViewModel> Evaluations { get; set; } = new();
       
    }
}
