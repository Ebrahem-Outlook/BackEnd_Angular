using BackEnd.Application.Core.Abstractions.Data;
using BackEnd.Domain.Products;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Infrastructure.Repositories;

internal sealed class ProductRepository(IDbContext dbContext) : IProductRepository
{
    public async Task AddAsync(Product product, CancellationToken cancellationToken = default)
    {
        await dbContext.Set<Product>().AddAsync(product, cancellationToken);
    }

    public async Task Update(Product product, CancellationToken cancellationToken = default)
    {
        dbContext.Set<Product>().Update(product);

        await Task.CompletedTask;
    }

    public async Task Delete(Product product, CancellationToken cancellationToken = default)
    {
        dbContext.Set<Product>().Remove(product);

        await Task.CompletedTask;
    }

    public async Task<List<Product>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return await dbContext.Set<Product>().ToListAsync(cancellationToken);
    }

    public async Task<Product?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await dbContext.Set<Product>().FindAsync(id, cancellationToken);
    }

    public async Task<List<Product>> GetByName(string name, CancellationToken cancellationToken = default)
    {
        return await dbContext.Set<Product>().Where(product => product.Name == name).ToListAsync(cancellationToken);
    }
}
