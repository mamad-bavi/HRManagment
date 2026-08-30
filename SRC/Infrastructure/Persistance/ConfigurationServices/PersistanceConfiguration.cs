using Domain.Entities.Base;
using GenericRepositories.Configurations;
using GenericRepositories.Settings;
using Microsoft.Extensions.DependencyInjection;
using Persistance.FluentApi;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Persistance.ConfigurationServices
{
    public static class PersistanceConfiguration
    {
        public static void AddConfigurationServices(this IServiceCollection services,
            DbConnectionSetting setting)
        {
            Assembly[] assemblies = [typeof(BaseEntity).Assembly,typeof(IBaseTypeConfiguration<>).Assembly];
            services.AddGenericConfigurations(setting, assemblies);
        }
    }
}
