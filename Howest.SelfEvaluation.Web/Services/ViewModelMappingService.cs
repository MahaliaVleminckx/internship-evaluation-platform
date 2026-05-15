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
            };
        }





    }
}
