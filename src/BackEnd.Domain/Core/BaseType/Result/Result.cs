namespace BackEnd.Domain.Core.BaseType.Result;

public class Result
{
    public bool IsSuccess { get; }

    public bool IsFailure => !IsSuccess;

    public Error Error { get; }
}
