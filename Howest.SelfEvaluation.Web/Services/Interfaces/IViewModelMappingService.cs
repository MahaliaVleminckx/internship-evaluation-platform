using Howest.SelfEvaluation.Core.Entities;
using Howest.SelfEvaluation.Web.Models;
using Howest.SelfEvaluation.Web.ViewModels;

namespace Howest.SelfEvaluation.Web.Services.Interfaces
{
    public interface IViewModelMappingService
    {
        ModuleViewModel MapToModuleViewModel(Module module);
        EvaluationViewModel MapToEvaluationViewModel(Evaluation evaluation);
        CompetenceDomainViewModel MapToCompetenceDomainViewModel(CompetenceDomain competenceDomain);
        CompetenceViewModel MapToCompetenceViewModel(Competence competence);
        StudentViewModel MapToStudentViewModel(ApplicationUser student);
    }
}
