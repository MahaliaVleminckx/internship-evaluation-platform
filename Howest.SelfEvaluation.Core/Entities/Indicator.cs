using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Howest.SelfEvaluation.Core.Entities
{
    public class Indicator : BaseEntity
    {
        public string Description { get; set; }
        public Guid CompetenceId { get; set; }
        public string ScaleValue { get; set; }
        public int ScaleValueScore { get; set; }
        public ICollection<EvaluationScore> StudentEvaluationScores { get; set; }
        public Competence Competence { get; set; }
    }
}
