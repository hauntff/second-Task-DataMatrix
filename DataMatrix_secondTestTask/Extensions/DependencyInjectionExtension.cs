using DataMatrix_secondTestTask.Interfaces;
using DataMatrix_secondTestTask.Repositories;
using DataMatrix_secondTestTask.Services;

namespace DataMatrix_secondTestTask.Extensions
{
    public static class DependencyInjectionExtension
    {
        //Here in a large project I would create two methods.
        //one for dependency injection of repositories and their interfaces, and the second for services and their interfaces
        public static IServiceCollection AddInfrasctructure(this IServiceCollection services)
        {
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderService, OrderService>();
            return services;
        }
    }
}
