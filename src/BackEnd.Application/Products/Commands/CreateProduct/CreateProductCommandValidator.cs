using FluentValidation;

namespace BackEnd.Application.Products.Commands.CreateProduct;

internal sealed class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
{
    public CreateProductCommandValidator()
    {
        RuleFor(product => product.Name).NotNull().NotEmpty().WithMessage("Name of product can't be null");

        RuleFor(product => product.Description).NotNull().NotEmpty().WithMessage("Description of product can't be null");

        RuleFor(product => product.Price).NotNull().NotEmpty().WithMessage("Price of product can't be null");

        RuleFor(product => product.Stock).NotNull().NotEmpty().WithMessage("Stock of product can't be null");
    }
}
