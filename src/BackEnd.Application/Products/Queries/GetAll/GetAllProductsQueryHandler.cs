using BackEnd.Application.Core.Abstractions.Messaging;
using BackEnd.Domain.Products;

namespace BackEnd.Application.Products.Queries.GetAll;

internal sealed class GetAllProductsQueryHandler : IQueryHandler<GetAllProductsQuery, List<Product>>
{
    public Task<List<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}


