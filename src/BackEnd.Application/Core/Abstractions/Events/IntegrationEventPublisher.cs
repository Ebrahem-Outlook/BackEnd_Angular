namespace BackEnd.Application.Core.Abstractions.Events;

public interface IntegrationEventPublisher
{
    void PublishEvent(IIntegrationEvent integrationEvent);
}
