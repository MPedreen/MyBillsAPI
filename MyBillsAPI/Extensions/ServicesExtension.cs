using MyBills.Application.Interfaces.Services;
using MyBills.Application.Services;

namespace MyBills.API.Extensions
{
    public static class ServicesExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IContaAppService, ContaAppService>();

            return services;
        }
    }
}
