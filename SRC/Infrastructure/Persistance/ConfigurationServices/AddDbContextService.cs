using Application.Utilities.ApplicationSettings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persistance.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistance.ConfigurationServices
{
    public static class AddDbContextService
    {
        public static void AddDbContext(this IServiceCollection services,DbConnectionSetting setting)
        {
            services.AddDbContext<HRDbContext>(option =>
            {
                option.UseSqlServer(setting.CommandConnectionString);
            });
        }
    }
}
