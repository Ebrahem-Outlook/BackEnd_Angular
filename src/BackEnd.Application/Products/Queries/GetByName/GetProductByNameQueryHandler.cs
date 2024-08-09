using BackEnd.Application.Core.Abstractions.Messaging;
using BackEnd.Domain.Products;

namespace BackEnd.Application.Products.Queries.GetByName;

internal sealed class GetProductByNameQueryHandler : IQueryHandler<GetProductByNameQuery, List<Product>>
{
    public Task<List<Product>> Handle(GetProductByNameQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
