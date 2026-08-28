using Application.Contracts.GenericContract;
using Application.Contracts.Location.CityContract;
using Microsoft.Extensions.DependencyInjection;
using Persistance.Repository.GenericRepository;
using Persistance.Repository.Location.CityRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistance.ConfigurationServices
{
    public static class AddLifecycleConfigurationServices
    {
        public static void AddLifecycles(this IServiceCollection services)
        {
            #region Generic scopes lifetime
            services.AddScoped(typeof(IRepositorySyncronize<>),typeof(RepositorySyncronize<>));
            services.AddScoped(typeof(IRepositoryPublicAsyncEFCore<>),typeof(RepositoryPublicAsyncEFCore<>));
            services.AddScoped(typeof(IRepositoryPublicAsyncDapper<>),typeof(RepositoryPublicAsyncDapper<>));
            services.AddScoped(typeof(IRepositoryPublicAsyncDtoEFCore<,>),typeof(RepositoryPublicAsyncDtoEFCore<,>));
            services.AddScoped(typeof(IRepositoryPublicAsyncDtoEFCore<,,>),typeof(RepositoryPublicAsyncDtoEFCore<,,>));
            services.AddScoped(typeof(IRepositoryPublicAsyncDtoEFCore<,,,>),typeof(RepositoryPublicAsyncDtoEFCore<,,,>));
            services.AddScoped(typeof(IRepositoryPublicAsyncDtoEFCore<,,,,>),typeof(RepositoryPublicAsyncDtoEFCore<,,,,>));
            #endregion

            #region Scopes lifetimes

            services.AddScoped<ICityCreateRepository, CityCreateRepository>();
            services.AddScoped<ICityUpdateRepository, CityUpdateRepository>();
            services.AddScoped<ICityGetByIdRepository, CityGetByIdRepository>();
            services.AddScoped<ICityGetListRepository, CityGetListRepository>();

            #endregion

        }
    }
}
