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

    //for demo purposes, not final
    public async Task<IActionResult> Dashboard()
    {
        //DEVELOPMENT ONLY since no login system yet
        //TODO: change this to the logged in student (user) id (refactor method to use Guid instead of name) once login implemented
        //for now its hardcoded for demo purposes and we didnt get to do login implementation
        BaseViewModel baseViewModel = new BaseViewModel() { Name = "test@test.com" };
        return View(baseViewModel);
    }

    [HttpGet]
    public async Task<IActionResult> FillDomain(Guid domainId)
    {
        var domain = await _evaluationService.GetDomainWithIndicatorsAsync(domainId);

        var vm = new StudentCompetencesViewModel
        {
            DomainId = domain.Id,
            EvaluationId = domain.EvaluationId,
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