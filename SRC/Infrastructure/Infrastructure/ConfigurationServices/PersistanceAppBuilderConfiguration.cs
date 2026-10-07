using Microsoft.AspNetCore.Builder;
using GenericRepository.Configurations;

namespace Infrastructure.ConfigurationServices
{
    public static class PersistanceAppBuilderConfiguration
    {

        public static void PersistanceAddAppBuilderConfiguration(this IApplicationBuilder app)
        {
            app.GenericAppConfiguration();
        }

    }
}
