using CentralDePedidos.Application.Commands;

namespace CentralDePedidos.Application.Interfaces.Services;

public interface IPedidoAppService : IDisposable
{
    Task Add(PedidoCreateCommand command);
}