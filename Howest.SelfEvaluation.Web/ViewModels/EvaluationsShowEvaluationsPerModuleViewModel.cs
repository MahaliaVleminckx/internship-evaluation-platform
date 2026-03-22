using Howest.SelfEvaluation.Core.Entities;

namespace Howest.SelfEvaluation.Web.ViewModels
{
    public class EvaluationsShowEvaluationsPerModuleViewModel : BaseUserViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? OwnerId { get; set; }
        public ApplicationUser Owner { get; set; }
        public string Description { get; set; }
        public ICollection<ApplicationUser> ApplicationUsers { get; set; }
        public ICollection<Evaluation> Evaluations { get; set; }
    }
}
