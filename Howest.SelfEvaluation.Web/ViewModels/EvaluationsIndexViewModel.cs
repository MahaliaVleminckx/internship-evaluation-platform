using Howest.SelfEvaluation.Core.Entities;

namespace Howest.SelfEvaluation.Web.ViewModels
{
    public class EvaluationsIndexViewModel : BaseUserViewModel
    {
        public string Username { get; set; }
        public ICollection<Module> OwnerModules { get; set; }
        public ICollection<Module> Modules { get; set; }
        public ICollection<EvaluationScore> StudentEvaluationScores { get; set; }
        public string Role { get; set; }
    }
}
