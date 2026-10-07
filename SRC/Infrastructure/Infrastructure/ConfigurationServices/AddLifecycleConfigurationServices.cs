using Application.Contracts.Location.CityContract;
using Infrastructure.Repository.Location.CityRepository;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.ConfigurationServices
{
    public static class AddLifecycleConfigurationServices
    {
        public static void AddLifecycles(this IServiceCollection services)
        {
            

            #region Scopes lifetimes

            services.AddScoped<ICityCreateRepository, CityCreateRepository>();
            services.AddScoped<ICityUpdateRepository, CityUpdateRepository>();
            services.AddScoped<ICityGetRepository, CityGetRepository>();
            services.AddScoped<ICityGetListRepository, CityGetListRepository>();

            #endregion

        }
    }
}
