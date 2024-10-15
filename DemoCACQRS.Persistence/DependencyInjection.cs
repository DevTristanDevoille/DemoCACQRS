using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using DemoCACQRS.Persistence.DemoCACQRSContext;

namespace DemoCACQRS.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<DemoCACQRSDbContext>((sp, options) =>
            {
                options.UseSqlServer(connectionString);
            });

            //var context = services.BuildServiceProvider().GetRequiredService<DemoCACQRSDbContext>();
            //context.Database.Migrate();

            return services;
        }
    }
}
