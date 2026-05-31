using Howest.SelfEvaluation.Core.Entities;
using Howest.SelfEvaluation.Web.Data;
using Howest.SelfEvaluation.Web.Services.Interfaces;
using Howest.SelfEvaluation.Web.ViewModels.Teacher;
using Microsoft.EntityFrameworkCore;

namespace Howest.SelfEvaluation.Web.Services
{
    public class OverlayService : IOverlayService
    {
        private readonly SelfEvaluationsDbContext _db;

        public OverlayService(SelfEvaluationsDbContext db)
        {
            _db = db;
        }

        public async Task<EvaluationOverlayViewModel> GetOverlayAsync(Guid domainId, Guid studentId)
        {
            var domain = await _db.CompetenceDomains
                .Include(d => d.Competences)
                .FirstOrDefaultAsync(d => d.Id == domainId);

            if (domain == null)
                return null;

            var student = await _db.ApplicationUsers
                .FirstOrDefaultAsync(u => u.Id == studentId);

            if (student == null)
                return null;

            var evaluations = await _db.Evaluations.ToListAsync();

            var overlayCompetences = new List<OverlayCompetenceViewModel>();

            foreach (var competence in domain.Competences ?? new List<Competence>())
            {
                var compVm = new OverlayCompetenceViewModel
                {
                    Name = competence.Name,
                    Description = competence.Description,
                    Evaluations = new List<OverlayEvaluationComparisonViewModel>()
                };

                foreach (var evaluation in evaluations)
                {
                    var studentScore = await _db.EvaluationScores.FirstOrDefaultAsync(s =>
                        s.CompetenceId == competence.Id &&
                        s.TargetUserId == studentId &&
                        s.UserId == studentId &&
                        s.EvaluationId == evaluation.Id);

                    var mentorScore = await _db.EvaluationScores.FirstOrDefaultAsync(s =>
                        s.CompetenceId == competence.Id &&
                        s.TargetUserId == studentId &&
                        s.UserId != studentId &&
                        s.EvaluationId == evaluation.Id);

                    var indicatorIds = new List<Guid>();

                    if (studentScore?.IndicatorId != null)
                        indicatorIds.Add(studentScore.IndicatorId.Value);

                    if (mentorScore?.IndicatorId != null)
                        indicatorIds.Add(mentorScore.IndicatorId.Value);

                    var indicators = indicatorIds.Any()
                        ? await _db.Indicators
                            .Where(i => indicatorIds.Contains(i.Id))
                            .ToDictionaryAsync(i => i.Id)
                        : new Dictionary<Guid, Indicator>();

                    Indicator? GetIndicator(EvaluationScore? score)
                    {
                        if (score?.IndicatorId == null) return null;

                        return indicators.TryGetValue(score.IndicatorId.Value, out var indicator)
                            ? indicator
                            : null;
                    }

                    var studentIndicator = GetIndicator(studentScore);
                    var mentorIndicator = GetIndicator(mentorScore);

                    compVm.Evaluations.Add(new OverlayEvaluationComparisonViewModel
                    {
                        EvaluationTitle = evaluation.Title,

                        StudentScore = studentIndicator?.ScaleValueScore,
                        MentorScore = mentorIndicator?.ScaleValueScore,

                        StudentScoreLabel = studentIndicator?.ScaleValue,
                        MentorScoreLabel = mentorIndicator?.ScaleValue,

                        StudentComment = studentScore?.ExtraInfo ?? "",
                        MentorComment = mentorScore?.ExtraInfo ?? ""
                    });
                }

                overlayCompetences.Add(compVm);
            }

            return new EvaluationOverlayViewModel
            {
                StudentId = studentId,
                StudentName = $"{student.Firstname} {student.Lastname}",
                OverlayCompetences = overlayCompetences
            };
        }
    }
}