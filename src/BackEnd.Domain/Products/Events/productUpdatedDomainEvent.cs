using BackEnd.Domain.Core.Events;

namespace BackEnd.Domain.Products.Events;

public sealed record productUpdatedDomainEvent(Product Product) : DomainEvent();
