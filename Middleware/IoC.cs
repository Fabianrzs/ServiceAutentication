using Microsoft.Extensions.DependencyInjection;
using WebApiAutentication.Repository;
using WebApiAutentication.Service;
using WebApiAutentication.UnitofWork;

namespace WebApiAutentication.Middleware
{
    public static class IoC
    {
        public static IServiceCollection AddDependency(this IServiceCollection services)
        {
            // DependencyInjection Contratos
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IJwtService, JwtService>();
            services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }
    }
}
