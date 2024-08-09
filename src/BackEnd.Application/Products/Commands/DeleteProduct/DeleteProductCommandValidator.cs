using FluentValidation;

namespace BackEnd.Application.Products.Commands.DeleteProduct;

internal sealed class DeleteProductCommandValidator : AbstractValidator<DeleteProductCommand>
{
    public DeleteProductCommandValidator()
    {
        RuleFor(product => product.ProductId).NotNull().NotEmpty().WithMessage("Product Id can't be null or empty.");
    }
}
