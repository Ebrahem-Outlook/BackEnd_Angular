using BackEnd.Application.Core.Abstractions.Messaging;
using BackEnd.Domain.Products;

namespace BackEnd.Application.Products.Queries.GetByName;

public sealed record GetProductByNameQuery(string Name) : IQuery<List<Product>>;
