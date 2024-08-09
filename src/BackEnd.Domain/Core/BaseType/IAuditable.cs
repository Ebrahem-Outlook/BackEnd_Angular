namespace BackEnd.Domain.Core.BaseType;

public interface IAuditable
{
    DateTime CreatedOnUtc { get; }

    DateTime? UpdatedOnUtc { get; }
}
