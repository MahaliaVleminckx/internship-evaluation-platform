using Howest.SelfEvaluation.Core.Entities;
using NuGet.Packaging;

namespace Howest.SelfEvaluation.Web.ViewModels
{
    public class CompetenceViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Indicator> Indicators { get; set; } = new List<Indicator>();

        //Extra action properties voor form
        public Guid? SelectedIndicatorId { get; set; }
        //public bool NotApplicable { get; set; }
        public string Comment { get; set; }
    }
}
