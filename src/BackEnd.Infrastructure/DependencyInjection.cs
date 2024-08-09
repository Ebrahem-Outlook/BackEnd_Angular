using BackEnd.Application.Core.Abstractions.Data;
using BackEnd.Domain.Products;
using BackEnd.Infrastructure.Database;
using BackEnd.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BackEnd.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureLayer(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
        {
            string? connection = configuration.GetConnectionString("Docker-Postgres") ?? throw new InvalidOperationException("ConnectionString not found...");

            options.UseNpgsql(connection);
        });

        services.AddScoped<IDbContext>(serviceProvider => serviceProvider.GetRequiredService<AppDbContext>());

        services.AddScoped<IUnitOfWork>(serviceProvider => serviceProvider.GetRequiredService<AppDbContext>());


        // Register Product Repository...and caching it.
        services.AddScoped<IProductRepository, ProductRepository>();

        return services;
    }
}
