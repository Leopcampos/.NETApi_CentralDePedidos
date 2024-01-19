namespace CentralDePedidos.Application.Events;

public abstract class BaseEvent
{
    public Guid? Id { get; set; }
    public DateTime? DataHoraCriacao { get; set; }
}