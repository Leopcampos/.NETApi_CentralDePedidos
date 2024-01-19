namespace CentralDePedidos.Application.Events;

public class PedidoRealizadoEvent : BaseEvent
{
    public string? DetalhesPedido { get; set; }
}