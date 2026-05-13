using Howest.SelfEvaluation.Core.Entities;

namespace Howest.SelfEvaluation.Web.ViewModels.Teacher
{
    public class TeacherShowDomainsPerEvaluationViewModel : BaseUserViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public bool IsPublished { get; set; }
        public Guid ModuleId { get; set; }
        public string? Description { get; set; }
        public ICollection<CompetenceDomain> CompetenceDomains { get; set; }
        public ICollection<EvaluationScore> StudentEvaluationScores { get; set; }
    }
}
