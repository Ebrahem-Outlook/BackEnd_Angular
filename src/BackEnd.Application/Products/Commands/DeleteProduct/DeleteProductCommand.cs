using BackEnd.Application.Core.Abstractions.Messaging;
using BackEnd.Domain.Products;

namespace BackEnd.Application.Products.Commands.DeleteProduct;

public sealed record DeleteProductCommand(Guid ProductId) : ICommand<Product>;

internal sealed class DeleteProductCommandHandler : ICommandHandler<DeleteProductCommand, Product>
{
    public Task<Product> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
