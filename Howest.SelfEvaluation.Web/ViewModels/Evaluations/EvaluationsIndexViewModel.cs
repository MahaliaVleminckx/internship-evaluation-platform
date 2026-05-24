using Howest.SelfEvaluation.Core.Entities;

namespace Howest.SelfEvaluation.Web.ViewModels
{
    public class EvaluationsIndexViewModel : BaseUserViewModel
    {
        public string Username { get; set; }
        public List<ModuleViewModel> OwnerModules { get; set; }
        public List<ModuleViewModel> Modules { get; set; }
        //public List<EvaluationScore> StudentEvaluationScores { get; set; }
        public string Role { get; set; }
    }
}
