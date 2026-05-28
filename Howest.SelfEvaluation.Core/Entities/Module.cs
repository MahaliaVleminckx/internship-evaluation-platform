using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Howest.SelfEvaluation.Core.Entities
{
    public class Module : BaseEntity
    {
        public string Name { get; set; }
        public Guid? OwnerId { get; set; }
        public ApplicationUser Owner { get; set; }
        public string Description { get; set; }
        public ICollection<ApplicationUser> ApplicationUsers { get; set; } = new List<ApplicationUser>();
        public ICollection<Evaluation> Evaluations { get; set; } = new List<Evaluation>();
    }
}
