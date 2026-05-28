using Howest.SelfEvaluation.Core.Entities;

namespace Howest.SelfEvaluation.Web.ViewModels
{
    public class EvaluationScoreViewModel
    {
        public Guid? EvaluationId { get; set; }
        public Guid? CompetenceId { get; set; }
        public bool NotApplicable { get; set; }
        public string ExtraInfo { get; set; }
        public Guid? UserId { get; set; }
        public Guid? TargetUserId { get; set; }
        public Guid? IndicatorId { get; set; }
    }
}
