using Howest.SelfEvaluation.Core.Entities;
using Howest.SelfEvaluation.Web.ViewModels.Teacher;

public class TeacherShowStudentsDetailsViewModel
{
    public Guid StudentId { get; set; }
    public Guid DomainId { get; set; }

    public List<StudentResultViewModel> Results { get; set; } = new();
}