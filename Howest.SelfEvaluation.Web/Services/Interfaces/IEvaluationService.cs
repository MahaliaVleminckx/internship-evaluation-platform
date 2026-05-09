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
<<<<<<< HEAD
<<<<<<< HEAD
        Task<IEnumerable<ApplicationUser>> GetAllStudentsForMentorAsync(Guid mentorId);
=======
        Task<Evaluation> GetEvaluationForStudentAsync(Guid evaluationId);
        Task SaveStudentEvaluationAsync(StudentEvaluationViewModel vm);
<<<<<<< HEAD
>>>>>>> 5c2afa9 (Added saving forms with static Id's)
=======
        Task<CompetenceDomain> GetDomainWithIndicatorsAsync(Guid domainId);
        Task SaveDomainEvaluationAsync(StudentDomainEvaluationViewModel vm);
        Task SaveCompetenceEvaluationAsync(StudentCompetencesViewModel vm);
>>>>>>> d4b44df (Fixed errors from PR feedback)
=======
        Task<Evaluation> GetEvaluationForStudentAsync(Guid evaluationId);
        Task SaveStudentEvaluationAsync(StudentEvaluationViewModel vm);
        Task<CompetenceDomain> GetDomainWithIndicatorsAsync(Guid domainId);
        Task SaveDomainEvaluationAsync(StudentDomainEvaluationViewModel vm);
        Task SaveCompetenceEvaluationAsync(StudentCompetencesViewModel vm);
>>>>>>> fecc8b71435f4d436208559558ad678da80a77a9
    }
}
