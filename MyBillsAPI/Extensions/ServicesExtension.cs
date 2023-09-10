using MyBills.Application.Interfaces.Services;
using MyBills.Application.Services;
using MyBills.Domain.Interfaces.Repositories;
using MyBills.Infra.Data.SqlServer.Repositories;

namespace MyBills.API.Extensions
{
    public static class ServicesExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IContaAppService, ContaAppService>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
