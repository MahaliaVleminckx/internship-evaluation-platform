namespace Howest.SelfEvaluation.Web.ViewModels
{
    public class IndicatorViewModel
    {
        public Guid Id { get; set; }
        public string Description { get; set; }

        public string ScaleValue { get; set; }
        public int ScaleValueScore { get; set; }
    }
}
