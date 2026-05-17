using Howest.SelfEvaluation.Core.Entities;

namespace Howest.SelfEvaluation.Web.ViewModels.Admin
{
    public class AdminUsersViewModel
    {
        public List<AdminUserItemsViewModel> Users { get; set; } = new();
        public string? SelectedRole { get; set; }
    }
}
