using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Howest.SelfEvaluation.Web.ViewModels.Admin
{
    public class AdminCreateUsersViewModel
    {
        [Display(Name ="Voornaam")]
        [Required(ErrorMessage = "Voornaam is verplicht")]
        public string Firstname { get; set; } = default!;
        [Display(Name = "Achternaam")]
        [Required(ErrorMessage = "Achternaam is verplicht")]
        public string Lastname { get; set; } = default!;
        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "E-mail is verplicht")]
        [EmailAddress(ErrorMessage = "Geen geldig E-mail adres")]
        public string Username { get; set; } = default!;
        [Display(Name = "Rol")]
        [Required(ErrorMessage = "Rol is verplicht")]

        public string Role { get; set; } = default!;
        public List<SelectListItem> Roles { get; set; } = new();
    }
}
