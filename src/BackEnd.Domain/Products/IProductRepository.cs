namespace BackEnd.Domain.Products;

public interface IProductRepository
{
    // Commands.
    Task AddAsync(Product product, CancellationToken cancellationToken = default);
    Task Update(Product product, CancellationToken cancellationToken = default);
    Task Delete(Product product, CancellationToken cancellationToken = default);

    // Queries.
    Task<List<Product>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<Product?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<List<Product>> GetByName(string name, CancellationToken cancellationToken = default);
}
