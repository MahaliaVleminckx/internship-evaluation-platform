using Howest.SelfEvaluation.Core.Entities;
using System.Collections.Generic;

namespace Howest.SelfEvaluation.Web.ViewModels.Teacher
{
    public class TeacherIndexViewModel : BaseUserViewModel
    {
        public string Username { get; set; }
        public ICollection<Module> OwnerModules { get; set; }
        public ICollection<Module> Modules { get; set; }
        public ICollection<EvaluationScore> TeacherEvaluationScores { get; set; }
        public string Role { get; set; }
    }

    }


