using Howest.SelfEvaluation.Web.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Howest.SelfEvaluation.Web.Services.Interfaces
{
    public interface IFormBuilderService
    {
        List<CheckboxModel<Guid>> GetCompetenceDomainsDistinctByName();
        List<SelectListItem> GetModules();
        CheckboxModel<bool> CreatePublishCheckbox();

    }
}
