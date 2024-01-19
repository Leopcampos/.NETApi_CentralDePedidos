using CentralDePedidos.Domain.Interfaces.Repositories;
using CentralDePedidos.Domain.Models;
using CentralDePedidos.Infra.Data.Contexts;

namespace CentralDePedidos.Infra.Data.Repositories;

public class ClienteRepository : BaseRepository<Cliente, Guid>, IClienteRepository
{
    private readonly DataContext? _dataContext;

    public ClienteRepository(DataContext? dataContext) : base(dataContext)
    {
        _dataContext = dataContext;
    }
}