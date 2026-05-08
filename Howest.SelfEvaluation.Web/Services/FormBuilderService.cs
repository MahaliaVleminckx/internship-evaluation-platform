using Howest.SelfEvaluation.Core.Entities;
using Howest.SelfEvaluation.Web.Data;
using Howest.SelfEvaluation.Web.Models;
using Howest.SelfEvaluation.Web.Services.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Howest.SelfEvaluation.Web.Services
{
    public class FormBuilderService : IFormBuilderService
    {
        private readonly SelfEvaluationsDbContext _db;

        public FormBuilderService(SelfEvaluationsDbContext db)
        {
            _db = db;
        }

        //service to reseed data in forms
        public List<CheckboxModel<Guid>> GetCompetenceDomainsDistinctByName()
        {
            //had to do this first. If I had a long linq query for competencedomains in viewmodel, it crashed
            var competenceDomainsDistinctById = _db
                    .CompetenceDomains
                    .GroupBy(c => c.Name)
                    .Select(g => g.First())
                    .ToList();

            return competenceDomainsDistinctById
                .Select(c => new CheckboxModel<Guid>
                {
                    Text = c.Name,
                    Value = c.Id,
                })
                .ToList();
        }

        public List<SelectListItem> GetModules()
        {
            return _db.Modules.Select(m => new SelectListItem
            {
                Value = m.Id.ToString(),
                Text = m.Name,
            }).ToList();
        }

        public CheckboxModel<bool> CreatePublishCheckbox()
        {
            return new CheckboxModel<bool>
            {
                Text = "Evaluatie publiceren?",
                
            };
        }

    }
}
