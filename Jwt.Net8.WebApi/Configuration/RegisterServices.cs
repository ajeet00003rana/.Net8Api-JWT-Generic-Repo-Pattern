using Project.Server.Auth;
using Project.DataAccess.Services;

namespace Project.Server.Configuration
{
    public static class RegisterService
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<IProjectService, ProjectService>();

            return services;
        }
    }
}
