using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Howest.SelfEvaluation.Core.Entities
{
    public class Evaluation : BaseEntity
    {
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsPublished { get; set; }
        public Guid ModuleId { get; set; }
        public string? Description { get; set; }
        public ICollection<CompetenceDomain> CompetenceDomains { get; set; }
        public ICollection<EvaluationScore> StudentEvaluationScores { get; set; }
    }
}
