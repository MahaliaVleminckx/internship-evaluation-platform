using Howest.SelfEvaluation.Core.Entities;
using Howest.SelfEvaluation.Web.Models;
using Howest.SelfEvaluation.Web.Services.Interfaces;
using Howest.SelfEvaluation.Web.ViewModels;

namespace Howest.SelfEvaluation.Web.Services
{
    public class ViewModelMappingService : IViewModelMappingService
    {
        public ModuleViewModel MapToModuleViewModel(Module module)
        {
            return new ModuleViewModel
            {
                Id = module.Id,
                Name = module.Name,
                Evaluations = module.Evaluations.Select(e => MapToEvaluationViewModel(e) ).ToList(),
                Description = module.Description,
            };
        }

        public EvaluationViewModel MapToEvaluationViewModel(Evaluation evaluation)
        {
            return new EvaluationViewModel
            {
                Id = evaluation.Id,
                IsPublished = evaluation.IsPublished,
                Title = evaluation.Title,
                EndDate = evaluation.EndDate,
            };
        }

        public CompetenceDomainViewModel MapToCompetenceDomainViewModel(CompetenceDomain competenceDomain)
        {
            return new CompetenceDomainViewModel
            {
                Id = competenceDomain.Id,
                Name = competenceDomain.Name,
                //EvaluationId = competenceDomain.EvaluationId,
                Competences = competenceDomain.Competences.Select(c => MapToCompetenceViewModel(c)).ToList()
            };
        }

        public CompetenceViewModel MapToCompetenceViewModel(Competence competence)
        {
            return new CompetenceViewModel
            {
                Id = competence.Id,
                Name = competence.Name,
                Description = competence.Description
            };
        }

        public StudentViewModel MapToStudentViewModel(ApplicationUser student)
        {
            return new StudentViewModel
            {
                UserId = student.Id,
                UserName = student.Username,
                Firstname = student.Firstname,
                Lastname = student.Lastname
            };
        }

        public EvaluationScoreViewModel MapToEvaluationScoreViewModel(EvaluationScore evaluationScore)
        {
            return new EvaluationScoreViewModel
            {
                EvaluationId = evaluationScore.EvaluationId,
                CompetenceId = evaluationScore.CompetenceId,
                ExtraInfo = evaluationScore.ExtraInfo,
                IndicatorId = evaluationScore.IndicatorId,
                NotApplicable = evaluationScore.NotApplicable,
                TargetUserId = evaluationScore.TargetUserId,
                UserId = evaluationScore.UserId,
            };
        }
    }
}
