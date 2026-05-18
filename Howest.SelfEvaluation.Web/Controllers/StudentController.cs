using Howest.SelfEvaluation.Web.Services.Interfaces;
using Howest.SelfEvaluation.Web.ViewModels;
using Howest.SelfEvaluation.Web.ViewModels.Student;
using Microsoft.AspNetCore.Mvc;

public class StudentController : Controller
{
    private readonly IEvaluationService _evaluationService;

    public StudentController(IEvaluationService evaluationService)
    {
        _evaluationService = evaluationService;
    }

    [HttpGet]
    public async Task<IActionResult> FillDomain(Guid domainId)
    {
        var domain = await _evaluationService.GetDomainWithIndicatorsAsync(domainId);

        var userId = Guid.Parse("00000000-0000-0000-0000-000000000001"); // TODO: replace later with logged-in user

        var scores = await _evaluationService.GetStudentResultsForDomainAsync(userId, domainId);

        var vm = new StudentCompetencesViewModel
        {
            DomainId = domain.Id,
            EvaluationId = domain.EvaluationId,
            DomainName = domain.Name,

            IsReadOnly = scores.Any(), 

            Competences = domain.Competences.Select(c => new StudentCompetenceViewModel
            {
                Id = c.Id,
                Name = c.Name,
                Description = c.Description,
                Indicators = c.Indicators.ToList(),

                SelectedIndicatorId = scores
                    .FirstOrDefault(s => s.CompetenceId == c.Id)?.IndicatorId,

                Comment = scores
                    .FirstOrDefault(s => s.CompetenceId == c.Id)?.ExtraInfo
            }).ToList()
        };

        return View(vm);
    }

    [HttpPost]
    public async Task<IActionResult> SubmitCompetenceEvaluation(StudentCompetencesViewModel vm)
    {
        if (!ModelState.IsValid)
            return View("FillDomain", vm);

        await _evaluationService.SaveCompetenceEvaluationAsync(vm);

        TempData["SuccessMessage"] = "Evaluatie opgeslagen!";

        return RedirectToAction("FillDomain", new { domainId = vm.DomainId });
    }

    [HttpGet]
    public async Task<IActionResult> ShowDomainResult(Guid domainId, Guid userId)
    {
        var scores = await _evaluationService.GetStudentResultsForDomainAsync(userId, domainId);

        var vm = new StudentShowEvaluationViewModel
        {
            EvaluationId = domainId, 
            UserId = userId,
            Results = scores.Select(r => new StudentEvaluationResultViewModel
            {
                CompetenceName = r.Indicator?.Competence?.Name,
                IndicatorDescription = r.Indicator?.Description,
                Score = r.NotApplicable ? null : r.Indicator?.ScaleValue,
                NotApplicable = r.NotApplicable,
                Comment = r.ExtraInfo
            }).ToList()
        };

        return View("ShowEvaluation", vm); 
    }
}