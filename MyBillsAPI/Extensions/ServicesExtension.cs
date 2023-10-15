using MyBills.Application.Interfaces.Services;
using MyBills.Application.Services;
using MyBills.Domain.Interfaces.Repositories;
using MyBills.Domain.Interfaces.Services;
using MyBills.Domain.Services;
using MyBills.Infra.Data.SqlServer.Repositories;

namespace MyBills.API.Extensions
{
    public static class ServicesExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IContaAppService, ContaAppService>();
            services.AddTransient<IContaDomainService, ContaDomainService>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
