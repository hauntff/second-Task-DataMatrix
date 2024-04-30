using DataMatrix_secondTestTask.Data;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataMatrix_secondTestTask.Extensions
{
    public static class ApplicationDbContextExtension
    {
        public static IServiceCollection AddDatabaseContext(this IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("DefaultConnection") ?? "";
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(connectionString));
            return services;
        }
    }
}
