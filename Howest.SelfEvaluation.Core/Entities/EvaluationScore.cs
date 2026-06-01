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
        public Guid? UserId { get; set; } //whoever fills in the evaluation: mentor/student/teacher/admin
        public Guid? TargetUserId { get; set; } //whoever the evaluation is meant for: student id when mentor fills in review towards a student
                                                // or TargetUserId = UserId when student fills in evaluation for theirself
        public ApplicationUser User { get; set; }
        public Guid? IndicatorId { get; set; }

        public Indicator? Indicator { get; set; }
        

        public Evaluation? Evaluation { get; set; }
    }
}
