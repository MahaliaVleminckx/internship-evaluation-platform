using Howest.SelfEvaluation.Core.Entities;

namespace Howest.SelfEvaluation.Web.ViewModels
{
    public class MentorEvaluationDomainsViewModel : BaseUserViewModel
    {
        public Guid EvaluationId { get; set; }
        public string Title { get; set; }
        public bool IsPublished { get; set; }
        public ICollection<CompetenceDomain> CompetenceDomains { get; set; } = new List<CompetenceDomain>();
    }
}
