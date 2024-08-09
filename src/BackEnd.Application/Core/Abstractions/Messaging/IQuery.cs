using MediatR;

namespace BackEnd.Application.Core.Abstractions.Messaging;

public interface IQuery<out TResponse> : IRequest<TResponse>
{

}
