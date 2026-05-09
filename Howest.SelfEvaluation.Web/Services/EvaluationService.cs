using Howest.SelfEvaluation.Core.Entities;
using Howest.SelfEvaluation.Web.Data;
using Howest.SelfEvaluation.Web.Services.Interfaces;
using Howest.SelfEvaluation.Web.ViewModels;
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
                .Where(e => e.Id == evaluationId && e.IsPublished == true)
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
        public async Task<Evaluation> GetEvaluationForStudentAsync(Guid evaluationId)
        {
            return await _db.Evaluations
                .Include(e => e.CompetenceDomains)
                    .ThenInclude(d => d.Competences)
                        .ThenInclude(c => c.Indicators)
                .FirstOrDefaultAsync(e => e.Id == evaluationId);
        }
        public async Task SaveStudentEvaluationAsync(StudentEvaluationViewModel vm)
        {
            var userId = Guid.Parse("00000000-0000-0000-0000-000000000001"); // tijdelijk hardcoded

            foreach (var q in vm.Questions)
            {
                var existing = await _db.EvaluationScores
                    .FirstOrDefaultAsync(x =>
                        x.EvaluationId == vm.EvaluationId &&
                        x.IndicatorId == q.QuestionId &&
                        x.UserId == userId);

                if (existing != null)
                {
                    existing.ExtraInfo = q.Answer;
                    existing.Updated = DateTime.UtcNow;
                }
                else
                {
                    var score = new EvaluationScore
                    {
                        Id = Guid.NewGuid(),
                        EvaluationId = vm.EvaluationId,
                        IndicatorId = q.QuestionId,
                        UserId = userId,
                        ExtraInfo = q.Answer,
                        NotApplicable = false,
                        Created = DateTime.UtcNow
                    };

                    _db.EvaluationScores.Add(score);
                }
            }

            await _db.SaveChangesAsync();
        }
        public async Task<CompetenceDomain> GetDomainWithIndicatorsAsync(Guid domainId)
        {
            return await _db.CompetenceDomains
                .Include(d => d.Competences)
                    .ThenInclude(c => c.Indicators)
                .FirstOrDefaultAsync(d => d.Id == domainId);
        }
        public async Task SaveDomainEvaluationAsync(StudentDomainEvaluationViewModel vm)
        {
            var userId = Guid.Parse("00000000-0000-0000-0000-000000000001");// tijdelijk hardcoded

            foreach (var i in vm.Indicators)
            {
                var existing = await _db.EvaluationScores
                    .FirstOrDefaultAsync(x =>
                        x.IndicatorId == i.IndicatorId &&
                        x.UserId == userId);

                if (existing != null)
                {
                    existing.ExtraInfo = i.ExtraInfo;
                    existing.NotApplicable = i.NotApplicable;
                    existing.Updated = DateTime.UtcNow;
                }
                else
                {
                    var score = new EvaluationScore
                    {
                        Id = Guid.NewGuid(),
                        IndicatorId = i.IndicatorId,
                        UserId = userId,
                        ExtraInfo = i.ExtraInfo,
                        NotApplicable = i.NotApplicable,
                        Created = DateTime.UtcNow
                    };

                    _db.EvaluationScores.Add(score);
                }
            }

            await _db.SaveChangesAsync();
        
        }
        public async Task SaveCompetenceEvaluationAsync(StudentCompetencesViewModel vm)
        {
            var userId = Guid.Parse("00000000-0000-0000-0000-000000000001"); // TEMP USER

            foreach (var competence in vm.Competences)
            {
                if (competence.SelectedIndicatorId == null)
                    continue;

                var existing = await _db.EvaluationScores
                    .FirstOrDefaultAsync(x =>
                        x.IndicatorId == competence.SelectedIndicatorId &&
                        x.UserId == userId);

                if (existing != null)
                {
                    existing.ExtraInfo = competence.Comment;
                    existing.Updated = DateTime.UtcNow;
                    existing.CompetenceId = competence.Id;
                }
                else
                {
                    var score = new EvaluationScore
                    {
                        Id = Guid.NewGuid(),
                        IndicatorId = competence.SelectedIndicatorId.Value,
                        CompetenceId = competence.Id,
                        UserId = userId,
                        ExtraInfo = competence.Comment,
                        Created = DateTime.UtcNow
                    };

                    _db.EvaluationScores.Add(score);
                }
            }

            await _db.SaveChangesAsync();
        }

    }
}
