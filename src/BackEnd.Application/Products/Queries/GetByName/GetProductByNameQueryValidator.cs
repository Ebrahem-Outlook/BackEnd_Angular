using FluentValidation;

namespace BackEnd.Application.Products.Queries.GetByName;

internal sealed class GetProductByNameQueryValidator : AbstractValidator<GetProductByNameQuery>
{
    public GetProductByNameQueryValidator()
    {
        RuleFor(product => product.Name).NotEmpty().NotEmpty().WithMessage("Name of product can't be null or empty.");
    }
}
