using Howest.SelfEvaluation.Web.Services.Interfaces;
using Howest.SelfEvaluation.Web.ViewModels;
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

        var vm = new StudentCompetencesViewModel
        {
            DomainId = domain.Id,
            //EvaluationId = domain.EvaluationId,
            DomainName = domain.Name,

            Competences = domain.Competences.Select(c => new StudentCompetenceViewModel
            {
                Id = c.Id,
                Name = c.Name,
                Description = c.Description,
                Indicators = c.Indicators.ToList()
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
}