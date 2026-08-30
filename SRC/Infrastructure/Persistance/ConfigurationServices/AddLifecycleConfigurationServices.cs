using Application.Contracts.Location.CityContract;
using Microsoft.Extensions.DependencyInjection;
using Persistance.Repository.Location.CityRepository;

namespace Persistance.ConfigurationServices
{
    public static class AddLifecycleConfigurationServices
    {
        public static void AddLifecycles(this IServiceCollection services)
        {
            

            #region Scopes lifetimes

            services.AddScoped<ICityCreateRepository, CityCreateRepository>();
            services.AddScoped<ICityUpdateRepository, CityUpdateRepository>();
            services.AddScoped<ICityGetByIdRepository, CityGetByIdRepository>();
            services.AddScoped<ICityGetListRepository, CityGetListRepository>();

            #endregion

        }
    }
}
