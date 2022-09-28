namespace VetSystem.Infrastructure.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using VetSystem.Infrastructure.Data.Models;
    using VetSystem.Infrastucture.Data.Models;

    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

           
        }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Breed> Breeds { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Medication> Medications { get; set; }
        public DbSet<MedicationCategory> MedicationCategories { get; set; }
        public DbSet<Disease> Diseases { get; set; }
        public DbSet<DiseaseCategory> DiseaseCategories { get; set; }
    }
}