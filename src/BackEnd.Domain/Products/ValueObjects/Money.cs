using BackEnd.Domain.Core.BaseType;

namespace BackEnd.Domain.Products.ValueObjects;

public sealed class Money : ValueObject
{
    protected override IEnumerable<object> GetEqualityComponents()
    {
        throw new NotImplementedException();
    }
}
