using Domain.Entities.Base;
using GenericRepository.Configurations;
using GenericRepository.Settings;
using Microsoft.Extensions.Configuration;
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
            //DbConnectionSetting setting = new()
            //{
            //    CommandConnectionString = Configuration.GetConnectionString("CommandConnectionString"),
            //    QueryConnectionString = Configuration.GetConnectionString("QueryConnectionString")
            //};

            AssembliesSetting assemblies = new();
            assemblies.EntitiesAssemblies = [typeof(BaseEntity).Assembly];
            assemblies.EntitiesConfigurationAssemblies = 
                [typeof(IBaseTypeConfiguration<>).Assembly];

            services.AddGenericConfigurations(setting, assemblies);
        }
    }
}
