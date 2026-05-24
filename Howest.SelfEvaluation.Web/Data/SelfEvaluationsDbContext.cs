using Howest.SelfEvaluation.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Howest.SelfEvaluation.Web.Data
{
	public class SelfEvaluationsDbContext : DbContext
	{

		public DbSet<ApplicationUser> ApplicationUsers { get; set; }
		public DbSet<Module> Modules { get; set; }
		public DbSet<Evaluation> Evaluations { get; set; }
		public DbSet<CompetenceDomain> CompetenceDomains { get; set; }
		public DbSet<Competence> Competences { get; set; }
		public DbSet<Indicator> Indicators { get; set; }

		public DbSet<EvaluationScore> EvaluationScores { get; set; }

		public SelfEvaluationsDbContext(DbContextOptions<SelfEvaluationsDbContext> options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{

			modelBuilder.Entity<Module>()
				.HasOne(m => m.Owner)
				.WithMany(o => o.OwnerModules)
				.HasForeignKey(m => m.OwnerId)
				.OnDelete(DeleteBehavior.NoAction);


			DataSeeder.Seed(modelBuilder);
			base.OnModelCreating(modelBuilder);
		}
	}
}
