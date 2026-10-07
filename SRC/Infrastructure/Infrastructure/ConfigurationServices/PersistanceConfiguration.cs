using Domain.Entities.Base;
using GenericRepository.Configurations;
using GenericRepository.Settings;
using Infrastructure.FluentApi;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Infrastructure.ConfigurationServices
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
