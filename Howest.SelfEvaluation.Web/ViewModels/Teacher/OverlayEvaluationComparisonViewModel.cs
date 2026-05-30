namespace Howest.SelfEvaluation.Web.ViewModels.Teacher
{
    public class OverlayEvaluationComparisonViewModel
    {
        public string EvaluationTitle { get; set; }

        public int? StudentScore { get; set; }
        public int? MentorScore { get;set; }

        public string StudentComment { get; set; }
        public string MentorComment {  get; set; }

        public string StudentScoreLabel { get; set; }
        public string MentorScoreLabel { get; set; }
    }
}
