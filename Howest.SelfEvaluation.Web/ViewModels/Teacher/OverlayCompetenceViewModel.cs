namespace Howest.SelfEvaluation.Web.ViewModels.Teacher
{
    public class OverlayCompetenceViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int? StudentScore { get; set; }
        public int? MentorScore { get; set; }
        public string StudentComment { get; set; }
        public string MentorComment { get; set; }
    }
}
