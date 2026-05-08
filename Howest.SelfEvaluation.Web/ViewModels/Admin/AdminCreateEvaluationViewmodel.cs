using Howest.SelfEvaluation.Core.Entities;
using Howest.SelfEvaluation.Web.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Howest.SelfEvaluation.Web.ViewModels.Admin
{
    public class AdminCreateEvaluationViewmodel
    {
        [Required]
        [DisplayName("Titel")]
        public string Title { get; set; }

        [Required]
        [DisplayName("Start datum")]
        public DateTime StartDate { get; set; }

        [Required]
        [DisplayName("Eind datum")]
        public DateTime? EndDate { get; set; }

        [DisplayName("Evaluatie publiceren?")]
        public bool IsPublished { get; set; } = false;

        [Required]
        [DisplayName("Module")]
        public Guid ModuleId { get; set; }

        public List<SelectListItem> Modules { get; set; }

        [Required]
        [DisplayName("Beschrijving")]
        public string Description { get; set; }
    }
}
