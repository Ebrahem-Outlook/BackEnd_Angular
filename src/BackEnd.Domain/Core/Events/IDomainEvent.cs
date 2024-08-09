using MediatR;

namespace BackEnd.Domain.Core.Events;

public interface IDomainEvent : INotification
{
    Guid Id { get; }

    DateTime OcurredOn { get; }
}
