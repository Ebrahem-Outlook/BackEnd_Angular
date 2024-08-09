using BackEnd.Domain.Core.BaseType;
using BackEnd.Domain.Products.Events;

namespace BackEnd.Domain.Products;

/// <summary>
/// 
/// </summary>
public sealed class Product : AggregateRoot, IAuditable
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="name"></param>
    /// <param name="description"></param>
    /// <param name="price"></param>
    /// <param name="stock"></param>
    private Product(string name, string description, decimal price, int stock)
        : base(Guid.NewGuid())
    {
        Name = name;
        Description = description;
        Price = price;
        Stock = stock;
        CreatedOnUtc = DateTime.UtcNow;
    }

    /// <summary>
    /// Required by EFCore.
    /// </summary>
    private Product() { }

    /// <summary>
    /// 
    /// </summary>
    public string Name { get; private set; } = default!;

    /// <summary>
    /// 
    /// </summary>
    public string Description { get; private set; } = default!;

    /// <summary>
    /// 
    /// </summary>
    public decimal Price { get; private set; }

    /// <summary>
    /// 
    /// </summary>
    public int Stock { get; private set; }

    /// <summary>
    /// 
    /// </summary>
    public DateTime CreatedOnUtc { get; }

    /// <summary>
    /// 
    /// </summary>
    public DateTime? UpdatedOnUtc { get; private set; }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="name"></param>
    /// <param name="description"></param>
    /// <param name="price"></param>
    /// <param name="stock"></param>
    /// <returns></returns>
    public static Product Create(string name, string description, decimal price, int stock)
    {
        Product product = new Product(name, description, price, stock);

        product.RaiseDomainEvent(new ProductCreatedDomainEvent(product));

        return product;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="name"></param>
    /// <param name="description"></param>
    /// <param name="price"></param>
    /// <param name="stock"></param>
    public void Update(string name, string description, decimal price, int stock)
    {
        Name = name;
        Description = description;
        Price = price;
        Stock = stock;
        UpdatedOnUtc = DateTime.UtcNow;

        RaiseDomainEvent(new productUpdatedDomainEvent(this));
    }
}
