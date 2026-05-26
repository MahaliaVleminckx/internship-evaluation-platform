using Howest.SelfEvaluation.Core.Entities;
using Howest.SelfEvaluation.Web.Data;
using Microsoft.EntityFrameworkCore;


namespace Howest.SelfEvaluation.Web.Services
{
    public class AdminUserService
    {
        private readonly SelfEvaluationsDbContext _db;

        public AdminUserService( SelfEvaluationsDbContext db)
        {
            _db = db;
        }

        public async Task<List<ApplicationUser>> GetUsers(string? role)
        {
            var query = _db.ApplicationUsers.AsQueryable();
            if (!string.IsNullOrEmpty(role))
            {
                query = query.Where(u => u.Role == role);

            }

            return await query.ToListAsync();

        }

        public async Task <ApplicationUser?> GetByIdAsync (Guid Id)
        {
            return await _db.ApplicationUsers.FirstOrDefaultAsync(u => u.Id == Id);
        }

        public async Task CreateAsync(ApplicationUser user)
        {
            _db.ApplicationUsers.Add(user);
            await _db.SaveChangesAsync();
        }

        public async Task UpdateAsync(ApplicationUser user)
        {
            _db.ApplicationUsers.Update(user);
            await _db.SaveChangesAsync();
        }

       public async Task DeactivateAsync (ApplicationUser user)
        {
            user.Deleted = DateTime.Now;
            await _db.SaveChangesAsync();
        }
        public async Task ReactivateAsync (ApplicationUser user)
        {
            user.Deleted = null;
            await _db.SaveChangesAsync();
        }

        public async Task<ApplicationUser?> GetByEmailAsync(string email)
        {
            email = email.ToLower();
            return await _db.ApplicationUsers.FirstOrDefaultAsync(u => u.Username == email);
        }

    }
}
