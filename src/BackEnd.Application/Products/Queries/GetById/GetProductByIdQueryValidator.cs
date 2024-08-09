using FluentValidation;

namespace BackEnd.Application.Products.Queries.GetById;

internal sealed class GetProductByIdQueryValidator : AbstractValidator<GetProductByIdQuery>
{
    public GetProductByIdQueryValidator()
    {
        RuleFor(product => product.ProductId).NotNull().NotEmpty().WithMessage("ProductId can't be null or empty.");
    }
}
