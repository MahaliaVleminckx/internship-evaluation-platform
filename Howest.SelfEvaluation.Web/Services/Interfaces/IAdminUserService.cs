using Howest.SelfEvaluation.Core.Entities;

namespace Howest.SelfEvaluation.Web.Services.Interfaces
{
    public interface IAdminUserService
    {
        Task<List<ApplicationUser>> GetUsers(string? role);
        Task<ApplicationUser?> GetByIdAsync(Guid id);
        Task<ApplicationUser?> GetByEmailAsync(string email);
        Task CreateAsync(ApplicationUser user);
        Task UpdateAsync(ApplicationUser user);
        Task DeactivateAsync(ApplicationUser user);
        Task ReactivateAsync(ApplicationUser user);
    }
}
