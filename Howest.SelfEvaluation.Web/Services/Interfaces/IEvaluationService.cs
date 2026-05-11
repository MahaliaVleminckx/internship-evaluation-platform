using Howest.SelfEvaluation.Core.Entities;
using Howest.SelfEvaluation.Web.ViewModels;

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

        // Student flow
        Task<Evaluation> GetEvaluationForStudentAsync(Guid evaluationId);
        Task SaveStudentEvaluationAsync(StudentEvaluationViewModel vm);

        // Domain + competence flow 
        Task<CompetenceDomain> GetDomainWithIndicatorsAsync(Guid domainId);
        Task SaveDomainEvaluationAsync(StudentDomainEvaluationViewModel vm); 
        Task SaveCompetenceEvaluationAsync(StudentCompetencesViewModel vm);
        Task<IEnumerable<ApplicationUser>> GetAllStudentsForMentorAsync(Guid mentorId);
        Task<bool> DoesModuleIdExistAsync(Guid moduleId);
    }
}