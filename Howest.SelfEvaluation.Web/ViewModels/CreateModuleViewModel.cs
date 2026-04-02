using Howest.SelfEvaluation.Core.Entities;

namespace Howest.SelfEvaluation.Web.ViewModels
{
    public class CreateModuleViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid? OwnerId { get; set; }
        public List<Guid> AssignedStudentIds { get; set; } = new();
        public List<ApplicationUser> Students { get; set; }
        public List<ApplicationUser> Teachers { get; set; }

    }
}
