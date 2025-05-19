using gymtime_citrino_app.Interfaces.Repositories;
using gymtime_citrino_app.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace gymtime_citrino_app.Infrastructure.Ioc.Factories
{
    public static class RepositoryFactory
    {
        public static IServiceCollection RegisterRepositories(this IServiceCollection repositories)
        {
            repositories.AddScoped<ILoginRepository, LoginRepository>();
            repositories.AddScoped<IRegisterRepository, RegisterRepository>();

            return repositories;
        }
    }
}
