using Howest.SelfEvaluation.Web.Models;

namespace Howest.SelfEvaluation.Web.ViewModels
{
    public class ModuleViewModel : BaseViewModel
    {
        
        public IEnumerable<EvaluationViewModel> Evaluations { get; set; }
        public string Description { get; set; }

    }
}
