using Howest.SelfEvaluation.Web.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Howest.SelfEvaluation.Web.Areas.Admin.ViewModels.Admin
{
    public class AdminCreateEvaluationViewmodel
    {
        [Required(ErrorMessage = "Gelieve een titel in te vullen")]
        [DisplayName("Titel")]
        public string Title { get; set; }

        [Required]
        [DisplayName("Start datum")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required]
        [DisplayName("Eind datum")]
        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }

        [Required]
        [DisplayName("Evaluatie publiceren?")]
        public CheckboxModel<bool> IsPublished { get; set; }

        [Required]
        [DisplayName("Module")]
        public Guid ModuleId { get; set; }

        public List<SelectListItem> Modules { get; set; }

        [Required(ErrorMessage = "Gelieve een beschrijving in te vullen")]
        [DisplayName("Beschrijving")]
        public string Description { get; set; }

        public List<CheckboxModel<Guid>> CompetenceDomains { get; set; } = new List<CheckboxModel<Guid>>();
    }
}
