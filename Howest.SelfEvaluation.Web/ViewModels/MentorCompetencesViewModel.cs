using Howest.SelfEvaluation.Core.Entities;

namespace Howest.SelfEvaluation.Web.ViewModels
{
    public class MentorCompetencesViewModel
    {
        public Guid EvaluationId { get; set; }
        public Guid DomainId { get; set; }
        public string DomainName { get; set; }
        public ICollection<Competence> Competences { get; set; }= new List<Competence>();

        public string Title { get; set; } = "Evaluatie Student";
    }
}
