using Howest.SelfEvaluation.Core.Entities;
using Howest.SelfEvaluation.Core.Enums;
using Howest.SelfEvaluation.Web.Data;
using Howest.SelfEvaluation.Web.Models;
using Howest.SelfEvaluation.Web.Services.Interfaces;
using Howest.SelfEvaluation.Web.ViewModels.Student;
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
                    .ThenInclude(s => s.Indicator)
                        .ThenInclude(i => i.Competence)
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

        public async Task<bool> DoesEvaluationTitleExist(string title)
        {
            return await _db
                .Evaluations
                .AnyAsync(e => e.Title.ToUpper() == title.ToUpper());
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
                        TargetUserId = userId,
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
                        TargetUserId = userId,
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
                        TargetUserId = userId,
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
<<<<<<< feature/student-view-evaluations
        public async Task<List<EvaluationScore>> GetStudentOwnResultsAsync(Guid userId, Guid evaluationId)
        {
            return await _db.EvaluationScores
                .Where(es =>
                    es.UserId == userId &&
                    es.EvaluationId == evaluationId
                )
                .Include(es => es.Indicator)
                    .ThenInclude(i => i.Competence)
                .ToListAsync();
        }
        public async Task<List<EvaluationScore>> GetStudentResultsForDomainAsync(Guid userId, Guid domainId)
        {
            return await _db.EvaluationScores
                .Where(es =>
                    es.UserId == userId &&
                    es.Indicator != null &&
                    es.Indicator.Competence != null &&
        public async Task<List<ApplicationUser>> GetStudentsForDomainAsync(Guid domainId)
        {
            return await _db.EvaluationScores
                .Where(es =>
                    es.Indicator != null &&
                    es.Indicator.Competence != null &&
                    es.Indicator.Competence.CompetenceDomainId == domainId
                )
                .Select(es => es.User)
                .Where(u => u.Role == "Student")
                .Distinct()
                .ToListAsync();
        }
        public async Task<List<EvaluationScore>> GetStudentResultsForDomainAsync(Guid studentId, Guid domainId)
        {
            return await _db.EvaluationScores
                .Where(es =>
                    es.UserId == studentId &&
                    es.Indicator.Competence.CompetenceDomainId == domainId
                )
                .Include(es => es.Indicator)
                    .ThenInclude(i => i.Competence)
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

            if (await DoesEvaluationTitleExist(adminCreateEvaluationViewmodel.Title))
            {
                return new ResultModel<Evaluation> { Errors = new List<string> { $"Een evaluatie met naam {adminCreateEvaluationViewmodel.Title} bestaat al" } };
            }

            //linking of competenceDomains and evaluation
            var selectedCompetenceDomainIds = adminCreateEvaluationViewmodel
                .CompetenceDomains
                .Where(c => c.IsSelected == true)
                .Select(c => c.Value)
                .ToList();
            var competenceDomains = new List<CompetenceDomain>();

            foreach(var id in selectedCompetenceDomainIds)
            {
                var competenceDomain = await GetDomainWithIndicatorsAsync(id);
                competenceDomains.Add(competenceDomain);
            }

            newEvaluation.CompetenceDomains = competenceDomains;

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

            if (adminUpdateEvaluationViewModel.EndDate < adminUpdateEvaluationViewModel.StartDate)
            {
                return new ResultModel<Evaluation> { Errors = new List<string> { $"Einddatum kan niet voor begindatum liggen" } };
            }

            if (await DoesEvaluationTitleExist(adminUpdateEvaluationViewModel.Title) && existingEvaluation.Id != adminUpdateEvaluationViewModel.Id)
            {
                return new ResultModel<Evaluation> { Errors = new List<string> { $"Een evaluatie met naam {adminUpdateEvaluationViewModel.Title} bestaat al" } };
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
            //linking of competenceDomains and evaluation
            var selectedCompetenceDomainIds = adminUpdateEvaluationViewModel
                .CompetenceDomains
                .Where(c => c.IsSelected == true)
                .Select(c => c.Value)
                .ToList();
            var competenceDomains = new List<CompetenceDomain>();

            foreach (var id in selectedCompetenceDomainIds)
            {
                var competenceDomain = await GetDomainWithIndicatorsAsync(id);
                competenceDomains.Add(competenceDomain);
            }

            existingEvaluation.CompetenceDomains = competenceDomains;

            _db.Evaluations.Update(existingEvaluation);
            await _db.SaveChangesAsync();
            return new ResultModel<Evaluation> { Data = existingEvaluation };
        }
    }
}