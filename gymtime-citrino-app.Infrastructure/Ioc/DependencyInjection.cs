using gymtime_citrino_app.Infrastructure.Ioc.Factories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace gymtime_citrino_app.Infrastructure.Ioc
{
    public static class DependencyInjection
    {
        public static IServiceCollection RegisterDependencies(this IServiceCollection services)
        {
            services.RegisterRepositories();
            services.RegisterServices();

            return services;
        }

        public static IServiceCollection RegisterConnectionServices(this IServiceCollection connections, IConfiguration configuration)
        {
            connections.AddInfrastructure(configuration);

            return connections;
        }
    }
}
