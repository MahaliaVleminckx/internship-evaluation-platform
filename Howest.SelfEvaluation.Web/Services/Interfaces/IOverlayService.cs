using Howest.SelfEvaluation.Web.ViewModels.Teacher;

namespace Howest.SelfEvaluation.Web.Services.Interfaces
{
    public interface IOverlayService
    {
        Task<EvaluationOverlayViewModel> GetOverlayAsync(Guid domainId, Guid studentId);
    }
}
