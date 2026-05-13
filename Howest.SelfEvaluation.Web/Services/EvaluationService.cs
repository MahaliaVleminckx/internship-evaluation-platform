using Howest.SelfEvaluation.Core.Entities;
using Howest.SelfEvaluation.Core.Enums;
using Howest.SelfEvaluation.Web.Data;
using Howest.SelfEvaluation.Web.Models;
using Howest.SelfEvaluation.Web.Services.Interfaces;
using Howest.SelfEvaluation.Web.ViewModels.Admin;
using Howest.SelfEvaluation.Web.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Howest.SelfEvaluation.Web.Services
{
    public class EvaluationService : IEvaluationService
    {
        private readonly SelfEvaluationsDbContext _db;

        public EvaluationService(SelfEvaluationsDbContext db)
        {
            _db = db;
        }

        public async Task<ApplicationUser> GetUserByUsernameAsync(string username)
        {
            return await _db.ApplicationUsers
                .Where(u => u.Username == username)
                .Include(u => u.OwnerModules)
                .Include(u => u.StudentEvaluationScores)
                .Include(u => u.Modules)
                    .ThenInclude(m => m.Evaluations)
                .FirstOrDefaultAsync();
        }

        public async Task<ApplicationUser> GetUserByIdAsync(Guid userId)
        {
            return await _db.ApplicationUsers
                .Where(u => u.Id == userId)
                .Include(u => u.OwnerModules)
                .Include(u => u.StudentEvaluationScores)
                .Include(u => u.Modules)
                    .ThenInclude(m => m.Evaluations)
                .FirstOrDefaultAsync();
        }

        public async Task<Module> GetModuleByIdAsync(Guid moduleId)
        {
            return await _db.Modules
                .Where(m => m.Id == moduleId)
                .Include(m => m.Owner)
                .Include(m => m.Evaluations)
                .FirstOrDefaultAsync();
        }

        public async Task<Evaluation> GetPublishedEvaluationByIdAsync(Guid evaluationId)
        {
            return await _db.Evaluations
                .Where(e => e.Id == evaluationId && e.IsPublished)
                .Include(e => e.StudentEvaluationScores)
                .Include(e => e.CompetenceDomains)
                    .ThenInclude(d => d.Competences)
                .FirstOrDefaultAsync();
        }

        public async Task<Evaluation> GetAnyEvaluationByIdAsync(Guid evaluationId)
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
            return await _db.Evaluations.ToListAsync();
        }

        public async Task<IEnumerable<Evaluation>> GetAllPublishedEvaluationsAsync()
        {
            return await _db.Evaluations
                .Where(e => e.IsPublished)
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
            var userId = Guid.Parse("00000000-0000-0000-0000-000000000001");

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
                    _db.EvaluationScores.Add(new EvaluationScore
                    {
                        Id = Guid.NewGuid(),
                        EvaluationId = vm.EvaluationId,
                        IndicatorId = q.QuestionId,
                        UserId = userId,
                        ExtraInfo = q.Answer,
                        NotApplicable = false,
                        Created = DateTime.UtcNow
                    });
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
            var userId = Guid.Parse("00000000-0000-0000-0000-000000000001");

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
                    _db.EvaluationScores.Add(new EvaluationScore
                    {
                        Id = Guid.NewGuid(),
                        IndicatorId = i.IndicatorId,
                        UserId = userId,
                        ExtraInfo = i.ExtraInfo,
                        NotApplicable = i.NotApplicable,
                        Created = DateTime.UtcNow
                    });
                }
            }

            await _db.SaveChangesAsync();
        }

        public async Task SaveCompetenceEvaluationAsync(StudentCompetencesViewModel vm)
        {
            var userId = Guid.Parse("00000000-0000-0000-0000-000000000001");

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
                    existing.EvaluationId = vm.EvaluationId;
                }
                else
                {
                    _db.EvaluationScores.Add(new EvaluationScore
                    {
                        Id = Guid.NewGuid(),
                        EvaluationId = vm.EvaluationId,
                        IndicatorId = competence.SelectedIndicatorId.Value,
                        CompetenceId = competence.Id,
                        UserId = userId,
                        ExtraInfo = competence.Comment,
                        Created = DateTime.UtcNow
                    });
                }
            }

            await _db.SaveChangesAsync();
        }
        public async Task<IEnumerable<ApplicationUser>> GetAllStudentsForMentorAsync(Guid mentorId)
        {
            return await _db.ApplicationUsers
                .Where(u => u.Role == "Student" && u.AssignedMentorId == mentorId)
                .ToListAsync();
        }

        public async Task<bool> DoesModuleIdExistAsync(Guid moduleId)
        {
            return await _db.Modules.AnyAsync(m => m.Id.Equals(moduleId));
        }

        public async Task<ResultModel<Evaluation>> CreateEvaluationAsync(AdminCreateEvaluationViewmodel adminCreateEvaluationViewmodel)
        {
            var newEvaluation = new Evaluation
            {
                Id = Guid.NewGuid(),
                Created = DateTime.UtcNow,
                ModuleId = adminCreateEvaluationViewmodel.ModuleId,
                Title = adminCreateEvaluationViewmodel.Title,
                Description = adminCreateEvaluationViewmodel.Description,
                StartDate = adminCreateEvaluationViewmodel.StartDate,
                EndDate = adminCreateEvaluationViewmodel.EndDate,
                IsPublished = adminCreateEvaluationViewmodel.IsPublished.IsSelected
            };

            var searchExistingEvaluation = await GetAnyEvaluationByIdAsync(newEvaluation.Id);
            if(searchExistingEvaluation is not null)
            {
                return new ResultModel<Evaluation> 
                { 
                    Errors = new List<string> { $"Aanmaken mislukt. Een evaluatie met id {searchExistingEvaluation.Id} bestaat al"} 
                };
            }

            if(newEvaluation.EndDate < newEvaluation.StartDate)
            {
                return new ResultModel<Evaluation> { Errors = new List<string> { $"Einddatum kan niet voor begindatum liggen" } };
            }

            //todo?: restructure database with competencedomain(id - name) then link in new table CompetenceDomainsEvalutions?
            //since project was delivered like this, currently leaving it like it was

            //linking of competenceDomains and evaluation
            List<CompetenceDomain> linkCompetenceDomainsToEvaluation = new List<CompetenceDomain>();
            var selectedCompetenceDomains = adminCreateEvaluationViewmodel
                .CompetenceDomains
                .Where(c => c.IsSelected == true)
                .ToList();

            for (int i = 0; i < selectedCompetenceDomains.Count(); i++)
            {
                var competenceDomain = selectedCompetenceDomains[i];

                linkCompetenceDomainsToEvaluation.Add(new CompetenceDomain
                {
                    Id = Guid.NewGuid(),
                    Created = DateTime.UtcNow,
                    EvaluationId = newEvaluation.Id,
                    Name = competenceDomain.Text
                });
            }

            await _db.CompetenceDomains.AddRangeAsync(linkCompetenceDomainsToEvaluation);
            await _db.Evaluations.AddAsync(newEvaluation);
            await _db.SaveChangesAsync();
            return new ResultModel<Evaluation> { Data = newEvaluation };
        }

        public async Task<ResultModel<Evaluation>> UpdateEvaluationAsync(AdminUpdateEvaluationViewModel adminUpdateEvaluationViewModel)
        {
            var existingEvaluation = await GetAnyEvaluationByIdAsync(adminUpdateEvaluationViewModel.Id);
            if(existingEvaluation is null)
            {
                return new ResultModel<Evaluation> { Errors = new List<string> { $"Aanpassen mislukt. Er werd geen evaluatie met id {adminUpdateEvaluationViewModel.Id} gevonden" } };
            }
            if (existingEvaluation.EndDate < existingEvaluation.StartDate)
            {
                return new ResultModel<Evaluation> { Errors = new List<string> { $"Einddatum kan niet voor begindatum liggen" } };
            }


            existingEvaluation.Id = adminUpdateEvaluationViewModel.Id;
            existingEvaluation.Title = adminUpdateEvaluationViewModel.Title;
            existingEvaluation.Description = adminUpdateEvaluationViewModel.Description;
            existingEvaluation.StartDate = adminUpdateEvaluationViewModel.StartDate;
            existingEvaluation.EndDate = adminUpdateEvaluationViewModel.EndDate;
            existingEvaluation.IsPublished = adminUpdateEvaluationViewModel.IsPublished.IsSelected;
            existingEvaluation.ModuleId = adminUpdateEvaluationViewModel.ModuleId;
            existingEvaluation.Updated = DateTime.UtcNow;

            //update linking, first deleting existing links and then re-adding
            foreach (var competenceDomain in existingEvaluation.CompetenceDomains)
            {
                _db.CompetenceDomains.Remove(competenceDomain);
            }

            //linking of competenceDomains and evaluation
            List<CompetenceDomain> linkCompetenceDomainsToEvaluation = new List<CompetenceDomain>();
            var selectedCompetenceDomains = adminUpdateEvaluationViewModel
                .CompetenceDomains
                .Where(c => c.IsSelected == true)
                .ToList();

            for (int i = 0; i < selectedCompetenceDomains.Count(); i++)
            {
                var competenceDomain = selectedCompetenceDomains[i];

                linkCompetenceDomainsToEvaluation.Add(new CompetenceDomain
                {
                    Id = Guid.NewGuid(),
                    Created = DateTime.UtcNow,
                    EvaluationId = existingEvaluation.Id,
                    Name = competenceDomain.Text
                });
            }

            await _db.CompetenceDomains.AddRangeAsync(linkCompetenceDomainsToEvaluation);
            _db.Update(existingEvaluation);
            await _db.SaveChangesAsync();
            return new ResultModel<Evaluation> { Data = existingEvaluation };
        }
    }
}