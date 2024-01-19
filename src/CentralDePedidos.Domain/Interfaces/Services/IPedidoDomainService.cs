using CentralDePedidos.Domain.Models;

namespace CentralDePedidos.Domain.Interfaces.Services;

public interface IPedidoDomainService : IDisposable
{
    void Add(Pedido pedido);
}