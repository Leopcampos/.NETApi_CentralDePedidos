using CentralDePedidos.Application.Events;

namespace CentralDePedidos.Application.Interfaces.Publishers;

public interface IEventPublisher
{
    Task Publish(BaseEvent @event);
}