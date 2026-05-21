using Howest.SelfEvaluation.Core.Entities;
using Howest.SelfEvaluation.Web.ViewModels;

public class StudentCompetencesViewModel
{
    public Guid EvaluationId { get; set; }
    public Guid DomainId { get; set; }

    public string Title { get; set; }
    public string DomainName { get; set; }

    public List<StudentCompetenceViewModel> Competences { get; set; }
    public bool IsReadOnly { get; set; }
}

public class StudentCompetenceViewModel
{
    public Guid Id { get; set; }

    public string Name { get; set; }
    public string Description { get; set; }

    public List<IndicatorViewModel> Indicators { get; set; }

    public Guid? SelectedIndicatorId { get; set; }
    public string Comment { get; set; }
    
}