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
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public ICollection<Module> OwnerModules { get; set; }
        public ICollection<Module> Modules { get; set; }
        public ICollection<EvaluationScore> StudentEvaluationScores { get; set; }
        public string Role { get; set; }
    }
}
