using BackEnd.Application.Core.Abstractions.Messaging;
using BackEnd.Domain.Products;

namespace BackEnd.Application.Products.Queries.GetAll;

public sealed record GetAllProductsQuery() : IQuery<List<Product>>;


