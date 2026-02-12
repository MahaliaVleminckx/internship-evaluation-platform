using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Howest.SelfEvaluation.Core.Entities
{
	public class Competence : BaseEntity
	{
		public string Name { get; set; }
		public Guid CompetenceDomainId { get; set; }
		public string Description { get; set; }
		public ICollection<Indicator> Indicators { get; set; }
		public ICollection<EvaluationScore> StudentEvaluationScores { get; set; }
	}
}
