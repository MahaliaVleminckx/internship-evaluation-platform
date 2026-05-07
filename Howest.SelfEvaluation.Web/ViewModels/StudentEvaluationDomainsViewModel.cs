using Howest.SelfEvaluation.Core.Entities;
using System.Diagnostics.Eventing.Reader;

namespace Howest.SelfEvaluation.Web.ViewModels
{
    public class StudentEvaluationDomainsViewModel : BaseUserViewModel
    {
        public Guid EvaluationId { get; set; }
        public string Title { get; set; }
        public bool IsPublished { get; set; }
        public ICollection<CompetenceDomain> CompetenceDomains { get; set; } = new List<CompetenceDomain>();
    }
}
