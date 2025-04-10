using Microsoft.EntityFrameworkCore;
using Repository;


namespace WebHireSync.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<RepositoryContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("sqlConnection"),
                sqlOptions => sqlOptions.MigrationsAssembly("WebHireSync"))); // Migrations Assembly değiştirildi
        }
    }
}
