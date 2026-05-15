using Howest.SelfEvaluation.Core.Entities;

namespace Howest.SelfEvaluation.Web.ViewModels
{
    public class EvaluationsShowDomainsPerEvaluationViewModel : BaseUserViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public bool IsPublished { get; set; }
        public Guid ModuleId { get; set; }
        public string Description { get; set; }
        public List<CompetenceDomainViewModel> CompetenceDomains { get; set; }
        //public ICollection<EvaluationScore> StudentEvaluationScores { get; set; }
    }
}
