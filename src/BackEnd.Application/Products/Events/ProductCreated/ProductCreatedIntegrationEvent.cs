using BackEnd.Application.Core.Abstractions.Events;
using BackEnd.Domain.Core.Events;
using BackEnd.Domain.Products.Events;

namespace BackEnd.Application.Products.Events.ProductCreated;

internal class ProductCreatedIntegrationEvent : IIntegrationEvent
{
    private readonly IDomainEventHandler<ProductCreatedDomainEvent> _domainEventHandler; 
}
