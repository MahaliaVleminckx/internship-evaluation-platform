using Howest.SelfEvaluation.Web.ViewModels.Student;

namespace Howest.SelfEvaluation.Web.ViewModels.Mentor
{
    public class MentorShowStudentsViewModel
    {
        public IEnumerable<StudentViewModel> Students { get; set; }
    }
}
