using Howest.SelfEvaluation.Core.Entities;

public class TeacherStudentDetailViewModel
{
    public Guid StudentId { get; set; }
    public Guid DomainId { get; set; }
    public List<EvaluationScore> Results { get; set; } = new();
}