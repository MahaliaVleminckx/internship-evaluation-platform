using System.ComponentModel.DataAnnotations;

namespace Howest.SelfEvaluation.Web.ViewModels.Admin
{
    public class AdminEditUsersViewModel
    {
        public Guid Id { get; set; }
        [Display(Name = "Voornaam")]
        [Required(ErrorMessage = "Voornaam is verplicht")]

        public string Firstname { get; set; }
        [Display(Name = "Achternaam")]
        [Required(ErrorMessage = "Achternaam is verplicht")]

        public string Lastname { get; set; }
        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "E-mail is verplicht")]
        [EmailAddress(ErrorMessage = "Geen geldig E-mail adres")]

        public string Username { get; set; }
        [Display(Name = "Rol")]
        [Required(ErrorMessage = "Rol is verplicht")]

        public string Role { get; set; }
    }
}
