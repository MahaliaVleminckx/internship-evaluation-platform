using Howest.SelfEvaluation.Core.Entities;
using Howest.SelfEvaluation.Web.Data;
using Howest.SelfEvaluation.Web.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Howest.SelfEvaluation.Web.Services
{
    public class EvaluationService : IEvaluationService
    {
        private readonly SelfEvaluationsContext _db;

        public EvaluationService(SelfEvaluationsContext db)
        {
            _db = db;
        }


        public async Task<ApplicationUser> GetUserByUsernameAsync(string username)
        {
            return await _db
                .ApplicationUsers
                .Where(u => u.Username == username)
                .Include(u => u.OwnerModules)
                .Include(u => u.StudentEvaluationScores)
                .Include(u => u.Modules)
                .ThenInclude(m => m.Evaluations)
                .FirstOrDefaultAsync();
        }

        public async Task<ApplicationUser> GetUserByIdAsync(Guid userId)
        {
            return await _db
                .ApplicationUsers
                .Where(u => u.Id == userId)
                .Include(u => u.OwnerModules)
                .Include(u => u.StudentEvaluationScores)
                .Include(u => u.Modules)
                .ThenInclude(m => m.Evaluations)
                .FirstOrDefaultAsync();
        }

        public async Task<Module> GetModuleByIdAsync(Guid moduleId)
        {
            //TODO: fix owner && ownerId null value
            return await _db
                .Modules
                .Where(m => m.Id == moduleId)
                .Include(m => m.Owner)
                .Include(m => m.Evaluations)
                .FirstOrDefaultAsync();
        }

        public async Task<Evaluation> GetEvaluationByIdAsync(Guid evaluationId)
        {
            return await _db
                .Evaluations
                .Where(e => e.Id == evaluationId)
                .Include(e => e.StudentEvaluationScores)
                .Include(e => e.CompetenceDomains)
                .ThenInclude(d => d.Competences)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Evaluation>> GetAllEvaluationsAsync()
        {
            return await _db
                .Evaluations
                .ToListAsync();
        }

        public async Task<IEnumerable<Evaluation>> GetAllPublishedEvaluationsAsync()
        {
            return await _db
                .Evaluations
                .Where(e => e.IsPublished == true)
                .ToListAsync();
        }

    }
}
