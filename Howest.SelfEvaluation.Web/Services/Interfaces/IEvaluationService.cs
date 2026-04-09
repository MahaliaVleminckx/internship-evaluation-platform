using Howest.SelfEvaluation.Core.Entities;
using Howest.SelfEvaluation.Web.ViewModels;
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
        Task<IEnumerable<Evaluation>> GetAllPublishedEvaluationsAsync();
        Task<Evaluation> GetEvaluationForStudentAsync(Guid evaluationId);
        Task SaveStudentEvaluationAsync(StudentEvaluationViewModel vm);
        Task<CompetenceDomain> GetDomainWithIndicatorsAsync(Guid domainId);
        Task SaveDomainEvaluationAsync(StudentDomainEvaluationViewModel vm);
        Task SaveCompetenceEvaluationAsync(StudentCompetencesViewModel vm);
    }
}
