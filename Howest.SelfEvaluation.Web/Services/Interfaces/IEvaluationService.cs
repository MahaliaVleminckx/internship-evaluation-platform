using Howest.SelfEvaluation.Core.Entities;
using Howest.SelfEvaluation.Web.ViewModels.Student;
using Howest.SelfEvaluation.Web.Models;
using Howest.SelfEvaluation.Web.ViewModels.Admin;
using Microsoft.Extensions.Configuration.UserSecrets;
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
        Task<List<EvaluationScore>> GetStudentOwnResultsAsync(Guid userId, Guid evaluationId);
        Task<List<EvaluationScore>> GetStudentResultsForDomainAsync(Guid userId, Guid domainId);
        Task<List<ApplicationUser>> GetStudentsForDomainAsync(Guid domainId);
        Task<List<EvaluationScore>> GetStudentResultsForDomainAsync(Guid studentId, Guid domainId);
        Task<bool> DoesModuleIdExistAsync(Guid moduleId);
        Task<ResultModel<Evaluation>> CreateEvaluationAsync(AdminCreateEvaluationViewmodel adminCreateEvaluationViewmodel);
        Task<ResultModel<Evaluation>> UpdateEvaluationAsync(AdminUpdateEvaluationViewModel adminUpdateEvaluationViewModel);
        Task<bool> DoesEvaluationTitleExist(string title);
    }
}