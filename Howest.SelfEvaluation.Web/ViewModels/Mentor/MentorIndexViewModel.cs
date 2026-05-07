using Howest.SelfEvaluation.Core.Entities;

namespace Howest.SelfEvaluation.Web.ViewModels.Mentor
{
    public class MentorIndexViewModel : StudentIdViewModel
    {
        public IEnumerable<Evaluation> Evaluations { get; set; }
    }
}
