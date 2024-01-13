using CentralDePedidos.Domain.Models;

namespace CentralDePedidos.Domain.Interfaces.Repositories;

public interface IProdutoRepository : IBaseRepository<Produto, Guid>
{
}