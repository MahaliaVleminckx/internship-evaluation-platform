using Howest.SelfEvaluation.Core.Entities;
using System.Diagnostics.Eventing.Reader;

namespace Howest.SelfEvaluation.Web.ViewModels
{
    public class StudentEvaluaationDomainsViewModel : BaseUserViewModel
    {
        public Guid EvaluationId { get; set; }
        public string Title { get; set; }
        public bool IsPublisched { get; set; }
        public ICollection<CompetenceDomain> CompetenceDomains { get; set; } = new List<CompetenceDomain>();
    }
}
