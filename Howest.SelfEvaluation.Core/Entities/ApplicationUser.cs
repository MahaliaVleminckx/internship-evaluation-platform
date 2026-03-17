using Howest.SelfEvaluation.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Howest.SelfEvaluation.Core.Entities
{
    public class ApplicationUser : BaseEntity
    {
        public string Username { get; set; }
        public ICollection<Module> OwnerModules { get; set; }
        public ICollection<Module> Modules { get; set; }
        public ICollection<EvaluationScore> StudentEvaluationScores { get; set; }
        public RoleTypes Role { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public DateTime? Deleted { get; set; }
    }
}
