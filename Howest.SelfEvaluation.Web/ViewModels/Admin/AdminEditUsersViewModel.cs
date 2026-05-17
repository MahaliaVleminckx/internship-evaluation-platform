using System.ComponentModel.DataAnnotations;

namespace Howest.SelfEvaluation.Web.ViewModels.Admin
{
    public class AdminEditUsersViewModel
    {
        public Guid Id { get; set; }
        [Display(Name = "Voornaam")]
        public string Firstname { get; set; }
        [Display(Name = "Achternaam")]
        public string Lastname { get; set; }
        [Display(Name = "E-mail")]
        public string Username { get; set; }
        [Display(Name = "Rol")]
        public string Role { get; set; }
    }
}
