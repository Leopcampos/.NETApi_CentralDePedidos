using CentralDePedidos.Domain.Interfaces.Repositories;
using CentralDePedidos.Domain.Models;
using CentralDePedidos.Infra.Data.Contexts;

namespace CentralDePedidos.Infra.Data.Repositories;

public class CobrancaRepository : BaseRepository<Cobranca, Guid>, ICobrancaRepository
{
    private readonly DataContext? _dataContext;

    public CobrancaRepository(DataContext? dataContext) : base(dataContext)
    {
        _dataContext = dataContext;
    }
}