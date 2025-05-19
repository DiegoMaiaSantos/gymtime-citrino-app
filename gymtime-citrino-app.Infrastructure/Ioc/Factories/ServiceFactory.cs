using gymtime_citrino_app.Interfaces.Services;
using gymtime_citrino_app.Services;
using Microsoft.Extensions.DependencyInjection;

namespace gymtime_citrino_app.Infrastructure.Ioc.Factories
{
    public static class ServiceFactory
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<IRegisterService, RegisterService>();

            return services;
        }
    }
}
