using Howest.SelfEvaluation.Core.Entities;
using Howest.SelfEvaluation.Web.Models;

namespace Howest.SelfEvaluation.Web.ViewModels.Mentor
{
    public class MentorIndexViewModel : StudentIdViewModel
    {
        public List<EvaluationViewModel> Evaluations { get; set; }
    }
}
