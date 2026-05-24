using Howest.SelfEvaluation.Core.Entities;
using Howest.SelfEvaluation.Web.Areas.Admin.ViewModels.Admin;
using Howest.SelfEvaluation.Web.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Howest.SelfEvaluation.Web.Services.Interfaces
{
    public interface IFormBuilderService
    {
        List<CheckboxModel<Guid>> GetCompetenceDomainsDistinctByName();
        List<SelectListItem> GetModules();
        CheckboxModel<bool> CreatePublishCheckbox();
        Task ReseedEvaluationUpdateFormAsync(AdminUpdateEvaluationViewModel viewModel, Evaluation existingEvaluation);
        Task ReseedEvaluationCreateFormAsync(AdminCreateEvaluationViewmodel viewModel);

    }
}
