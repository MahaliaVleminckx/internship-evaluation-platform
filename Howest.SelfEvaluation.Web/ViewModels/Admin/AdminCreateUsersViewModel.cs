using System.ComponentModel.DataAnnotations;

namespace Howest.SelfEvaluation.Web.ViewModels.Admin
{
    public class AdminCreateUsersViewModel
    {
        [Display(Name ="Voornaam")]
        public string Firstname { get; set; } = default!;
        [Display(Name = "Achternaam")]
        public string Lastname { get; set; } = default!;
        [Display(Name = "E-mail")]
        public string Username { get; set; } = default!;
        [Display(Name = "Rol")]
        public string Role { get; set; } = default!;
    }
}
