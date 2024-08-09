namespace BackEnd.Domain.Products;

public interface IProductRepository
{
    // Commands.
    Task AddAsync(Product product, CancellationToken cancellationToken = default);
    Task Update(Product product, CancellationToken cancellationToken = default);
    Task Delete(Product product, CancellationToken cancellationToken = default);

    // Queries.
    Task GetAllAsync(CancellationToken cancellationToken = default);
    Task GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task GetByName(string name, CancellationToken cancellationToken = default);
}
