using Howest.SelfEvaluation.Core.Entities;
using Howest.SelfEvaluation.Web.ViewModels.Mentor;

namespace Howest.SelfEvaluation.Web.ViewModels.Teacher
{
    public class EvaluationOverlayViewModel : BaseUserViewModel
    {
        public MentorEvaluationDomainsViewModel MentorEvaluation {  get; set; }
        
        public StudentEvaluationDomainsViewModel StudentsEvaluation { get; set; }

        public string StudentName { get; set; }
        public Guid StudentId { get; set; }

        public List<OverlayCompetenceViewModel> OverlayCompetences { get; set; } = new();
    }
}
