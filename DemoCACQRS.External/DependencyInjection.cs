using CatalogService.External.Spotify.Services;
using DemoCACQRS.External.Common.Interfaces;
using DemoCACQRS.External.Common.Services;
using DemoCACQRS.External.Spotify.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DemoCACQRS.External
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddExternalServices(this IServiceCollection services)
        {
            services.AddScoped<IHttpService, HttpService>();
            services.AddScoped<ISpotifyService, SpotifyService>();

            return services;
        }
    }
}
