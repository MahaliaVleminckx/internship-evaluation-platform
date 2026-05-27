namespace Howest.SelfEvaluation.Web.ViewModels.Teacher
{
    public class OverlayCompetenceViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        //public int? StudentScore { get; set; }
        //public int? MentorScore { get; set; }
        //public string StudentComment { get; set; }
        public List<OverlayEvaluationComparisonViewModel> Evaluations { get; set; } = new();
        //public string MentorComment { get; set; }
        //public string StudentScoreLabel { get; set; }
        //public string MentorScoreLabel { get; set; }
    }
}
