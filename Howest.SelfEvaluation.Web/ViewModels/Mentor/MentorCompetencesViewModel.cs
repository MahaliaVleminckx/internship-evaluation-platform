using Howest.SelfEvaluation.Core.Entities;

namespace Howest.SelfEvaluation.Web.ViewModels.Mentor
{
    public class MentorCompetencesViewModel : StudentIdViewModel
    {
        public Guid EvaluationId { get; set; }
        public Guid DomainId { get; set; }
        public string DomainName { get; set; }

        public string Title { get; set; } = "Evaluatie Student";

        public List<CompetenceViewModel> Competences { get; set; } = new List<CompetenceViewModel>();
    }
}
