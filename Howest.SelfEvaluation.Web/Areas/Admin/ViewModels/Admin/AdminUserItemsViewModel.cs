
namespace Howest.SelfEvaluation.Web.ViewModels.Admin
{
    public class AdminUserItemsViewModel
    {
        public Guid Id { get; set; }
        public string Username { get; set; } = default!;
        public string Firstname { get; set; } = default!;
        public string Lastname { get; set; } = default!;
        public string Role {  get; set; } = default!;
        public DateTime? Deleted { get; set; }
        public DateTime Created {  get; set; }
    }
}

