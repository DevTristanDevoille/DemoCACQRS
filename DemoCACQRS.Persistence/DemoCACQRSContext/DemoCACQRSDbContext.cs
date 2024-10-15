using DemoCACQRS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DemoCACQRS.Persistence.DemoCACQRSContext
{
    public class DemoCACQRSDbContext : DbContext
    {
        public DemoCACQRSDbContext() : base()
        {
            
        }

        public DemoCACQRSDbContext(DbContextOptions<DemoCACQRSDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Si le contexte n'est pas encore configuré, configure-le ici pour les commandes design-time
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=DemoCACQRSDb;Trusted_Connection=True;");
            }
        }

        public DbSet<Song> Songs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema("Songs");

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
