namespace Howest.SelfEvaluation.Web.ViewModels.Teacher
{
    public class StudentResultViewModel
    {
        public string CompetenceName { get; set; }
        public string IndicatorDescription { get; set; }
        public string? Score { get; set; }
        public bool NotApplicable { get; set; }
        public string? Comment { get; set; }
    }
}
