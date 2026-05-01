using Howest.SelfEvaluation.Core.Entities;
using System;

namespace Howest.SelfEvaluation.Web.ViewModels.Teacher
{
    public class TeacherShowEvaluationsPerModuleViewModel
    {
        public Guid ModuleId { get; set; }
        public string ModuleName { get; set; }
        public string ModuleDescription { get; set; }
        public List<Evaluation> Evaluations { get; set; }
        public Guid UserId { get; set; }
    }
}
