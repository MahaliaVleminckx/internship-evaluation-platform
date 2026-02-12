using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Howest.SelfEvaluation.Core.Entities
{
    public class EvaluationScore : BaseEntity
    {
        public Guid? EvaluationId { get; set; }
        public Guid? CompetenceId { get; set; }
        public bool NotApplicable { get; set; }
        public string? ExtraInfo { get; set; }
        public Guid? UserId { get; set; } //mentor or student
        public ApplicationUser User { get; set; }
        public Guid? IndicatorId { get; set; }
        
    }
}
