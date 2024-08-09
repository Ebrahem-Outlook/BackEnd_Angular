using BackEnd.Application.Core.Abstractions.Messaging;
using BackEnd.Domain.Products;

namespace BackEnd.Application.Products.Queries.GetById;

public sealed record GetProductByIdQuery(Guid ProductId) : IQuery<Product>;
