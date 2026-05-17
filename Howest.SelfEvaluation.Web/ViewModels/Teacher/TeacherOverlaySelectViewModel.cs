using Howest.SelfEvaluation.Core.Entities;

namespace Howest.SelfEvaluation.Web.ViewModels.Teacher
{
    public class TeacherOverlaySelectViewModel
    {
        public Guid? StudentId { get; set; }
        public Guid? EvaluationId { get; set; }
        public Guid? DomainId { get; set; }

        public List<ApplicationUser> Students { get; set; }
        public List<Evaluation> Evaluations { get; set; }
        public List<CompetenceDomain> Domains { get; set; }
    }
}
