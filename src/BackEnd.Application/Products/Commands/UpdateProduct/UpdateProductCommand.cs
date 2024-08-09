using BackEnd.Application.Core.Abstractions.Messaging;
using BackEnd.Domain.Products;

namespace BackEnd.Application.Products.Commands.UpdateProduct;

public sealed record UpdateProductCommand(
    Guid ProductId, 
    string Name, 
    string Description, 
    decimal Price, 
    int Stock) : ICommand<Product>;
