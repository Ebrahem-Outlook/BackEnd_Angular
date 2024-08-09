using BackEnd.Application.Core.Abstractions.Messaging;
using BackEnd.Domain.Products;

namespace BackEnd.Application.Products.Commands.CreateProduct;

public sealed record CreateProductCommand(
    string Name,
    string Description, 
    decimal Price, 
    int Stock) : ICommand<Product>;
