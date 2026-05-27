public class StudentDomainEvaluationViewModel
{
    public Guid DomainId { get; set; }
    public string DomainName { get; set; }

    public List<IndicatorAnswerViewModel> Indicators { get; set; }
}

public class IndicatorAnswerViewModel
{
    public Guid IndicatorId { get; set; }
    public string Description { get; set; }

    public int? Score { get; set; }   // radio buttons
    public string ExtraInfo { get; set; }
    public bool NotApplicable { get; set; }
}