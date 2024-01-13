using CentralDePedidos.Domain.Models;

namespace CentralDePedidos.Domain.Interfaces.Repositories;

public interface IPedidoRepository : IBaseRepository<Pedido, Guid>
{
}