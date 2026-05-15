using Howest.SelfEvaluation.Core.Entities;

namespace Howest.SelfEvaluation.Web.ViewModels
{
    public class CompetenceDomainViewModel : BaseViewModel
    {
        public Guid EvaluationId { get; set; }
        public List<CompetenceViewModel> Competences { get; set; }
    }
}
