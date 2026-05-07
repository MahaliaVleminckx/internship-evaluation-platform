using Howest.SelfEvaluation.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Howest.SelfEvaluation.Web.Data
{
	public class SelfEvaluationsContext : DbContext
	{

		public DbSet<ApplicationUser> ApplicationUsers { get; set; }
		public DbSet<Module> Modules { get; set; }
		public DbSet<Evaluation> Evaluations { get; set; }
		public DbSet<CompetenceDomain> CompetenceDomains { get; set; }
		public DbSet<Competence> Competences { get; set; }
		public DbSet<Indicator> Indicators { get; set; }

		public DbSet<EvaluationScore> EvaluationScores { get; set; }

		public SelfEvaluationsContext(DbContextOptions<SelfEvaluationsContext> options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{

			modelBuilder.Entity<Module>()
				.HasOne(m => m.Owner)
				.WithMany(o => o.OwnerModules)
				.HasForeignKey(m => m.OwnerId)
				.OnDelete(DeleteBehavior.NoAction);

			modelBuilder.Entity<ApplicationUser>()
				.HasMany(a => a.Modules)
				.WithMany(a => a.ApplicationUsers)
				.UsingEntity<ApplicationUserModule>();
			//.UsingEntity(j => j.ToTable("ApplicationUserModule"));



			DataSeeder.Seed(modelBuilder);
			base.OnModelCreating(modelBuilder);
		}
	}
}
