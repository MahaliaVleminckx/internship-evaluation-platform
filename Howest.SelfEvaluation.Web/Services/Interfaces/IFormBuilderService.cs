using Howest.SelfEvaluation.Web.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Howest.SelfEvaluation.Web.Services.Interfaces
{
    public interface IFormBuilderService
    {
        public List<CheckboxModel<Guid>> GetCompetenceDomainsDistinctByName();
        public List<SelectListItem> GetModules();
        public CheckboxModel<bool> CreatePublisherCheckbox();

    }
}
