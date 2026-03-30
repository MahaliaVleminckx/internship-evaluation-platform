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
    public async Task<IActionResult> Fill(Guid evaluationId)
    {
        var evaluation = await _evaluationService.GetEvaluationForStudentAsync(evaluationId);

        var vm = new StudentEvaluationViewModel
        {
            EvaluationId = evaluation.Id,
            Questions = evaluation.CompetenceDomains
                .SelectMany(d => d.Competences)
                .SelectMany(c => c.Indicators)
                .Select(i => new QuestionAnswerViewModel
                {
                    QuestionId = i.Id,
                    QuestionText = i.Description
                }).ToList()
        };

        return View(vm);
    }

    [HttpPost]
    public async Task<IActionResult> Fill(StudentEvaluationViewModel vm)
    {
        if (!ModelState.IsValid)
            return View(vm);

        await _evaluationService.SaveStudentEvaluationAsync(vm);

        return RedirectToAction("Index");
    }
// Test Code
    [HttpGet]
    public async Task<IActionResult> TestSave()
    {
        var vm = new StudentEvaluationViewModel
        {
            EvaluationId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
            Questions = new List<QuestionAnswerViewModel>
            {
                new QuestionAnswerViewModel
                {
                    QuestionId = Guid.Parse("00000000-0000-0000-0000-000000000029"),
                    Answer = "Test answer from controller"
                }
            }
        };

        await _evaluationService.SaveStudentEvaluationAsync(vm);

        return Content("Saved!");
    }
}
