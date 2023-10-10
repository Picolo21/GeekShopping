using GeekShopping.ProductAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI;

public static class Bootstrap
{
    public static IServiceCollection AddInjections(this IServiceCollection services)
    {
        services.AddRepositories();

        return services;
    }

    public static void AddRepositories(this IServiceCollection services)
    {
        services.AddDbContext<SqlServerContext>(options =>
            options.UseSqlServer(Environment.GetEnvironmentVariable("SQLServerConnection:SQLServerConnectionString")));
    }
}
