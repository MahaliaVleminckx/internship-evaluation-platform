using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Howest.SelfEvaluation.Core.Entities
{
	public class CompetenceDomain : BaseEntity
	{
		public string Name { get; set; }
        //public Guid EvaluationId { get; set; }
        public ICollection<Evaluation> Evaluations { get; set; }
        public ICollection<Competence> Competences { get; set; }
	}
}
