using Howest.SelfEvaluation.Web.Models;

namespace Howest.SelfEvaluation.Web.Services.Interfaces
{
    public interface IFormBuilderService
    {
        public List<CheckboxModel<Guid>> GetCompetenceDomainsDistinctById();

    }
}
