using BackEnd.Domain.Core.Events;

namespace BackEnd.Domain.Products.Events;

public sealed record ProductCreatedDomainEvent(Product Product) : DomainEvent();
