using Howest.SelfEvaluation.Core.Entities;
using Microsoft.Extensions.Configuration.UserSecrets;

namespace Howest.SelfEvaluation.Web.Services.Interfaces
{
    public interface IEvaluationService
    {
        Task<ApplicationUser> GetUserByUsernameAsync(string username);
        Task<ApplicationUser> GetUserByIdAsync(Guid userId);
        Task<Module> GetModuleByIdAsync(Guid moduleId);
        Task<Evaluation> GetEvaluationByIdAsync(Guid id);
        Task<IEnumerable<Evaluation>> GetAllEvaluationsAsync();
    }
}
