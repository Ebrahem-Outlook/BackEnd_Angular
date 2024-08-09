using BackEnd.Domain.Core.Events;

namespace BackEnd.Domain.Core.BaseType;

public abstract class AggregateRoot : Entity, IAggregateRoot
{
    protected AggregateRoot(Guid id) : base(id) { } 

    protected AggregateRoot() : base(){ }

    private readonly List<IDomainEvent> domainEvents = [];

    public IReadOnlyCollection<IDomainEvent> DomainEvent => domainEvents.AsReadOnly();

    public void RaiseDomainEvent(IDomainEvent @event) => domainEvents.Add(@event);

    public void ClearDomainEvent() => domainEvents.Clear();
}

public interface IAggregateRoot
{
    IReadOnlyCollection<IDomainEvent> DomainEvent { get; }

    void RaiseDomainEvent(IDomainEvent @event);

    void ClearDomainEvent();
}
