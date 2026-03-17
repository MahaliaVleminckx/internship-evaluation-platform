using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Howest.SelfEvaluation.Core.Entities
{
    public class ApplicationUserModule
    {
        public Guid ApplicationUserId { get; set; }
        public Guid ModuleId { get; set; }
    }
}
