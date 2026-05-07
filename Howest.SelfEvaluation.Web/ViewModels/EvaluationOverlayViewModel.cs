using Howest.SelfEvaluation.Core.Entities;

namespace Howest.SelfEvaluation.Web.ViewModels
{
    public class EvaluationOverlayViewModel : BaseUserViewModel
    {
        public MentorEvaluationDomainsViewModel MentorEvaluation {  get; set; }
        
        public StudentEvaluationDomainsViewModel StudentsEvaluation { get; set; }

        public string StudentName { get; set; }
        public Guid StudentId { get; set; }
    }
}
