using Howest.SelfEvaluation.Core.Entities;
using Microsoft.Extensions.Configuration.UserSecrets;

namespace Howest.SelfEvaluation.Web.Services.Interfaces
{
    public interface IEvaluationService
    {
        Task<ApplicationUser> GetUserByUsernameAsync(string username);
        Task<ApplicationUser> GetUserByIdAsync(Guid userId);
        Task<Module> GetModuleByIdAsync(Guid moduleId);
        Task<Evaluation> GetPublishedEvaluationByIdAsync(Guid id);
        Task<Evaluation> GetAnyEvaluationByIdAsync(Guid evaluationId);
        Task<IEnumerable<Evaluation>> GetAllEvaluationsAsync();
        Task<IEnumerable<Evaluation>> GetAllPublishedEvaluationsAsync();
        Task<IEnumerable<ApplicationUser>> GetAllStudentsForMentorAsync(Guid mentorId);
        Task<bool> DoesModuleIdExistAsync(Guid moduleId);
    }
}
