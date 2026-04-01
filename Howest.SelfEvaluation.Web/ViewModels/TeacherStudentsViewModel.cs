using Howest.SelfEvaluation.Core.Entities;

public class TeacherStudentsViewModel
{
    public Guid EvaluationId { get; set; }
    public List<ApplicationUser> Students { get; set; }
}