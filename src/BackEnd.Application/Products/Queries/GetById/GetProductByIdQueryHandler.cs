using BackEnd.Application.Core.Abstractions.Messaging;
using BackEnd.Domain.Products;

namespace BackEnd.Application.Products.Queries.GetById;

internal sealed class GetProductByIdQueryHandler : IQueryHandler<GetProductByIdQuery, Product>
{
    public Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
