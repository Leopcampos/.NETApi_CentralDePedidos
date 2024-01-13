using CentralDePedidos.Domain.Interfaces.Repositories;
using CentralDePedidos.Domain.Models;
using CentralDePedidos.Infra.Data.Contexts;

namespace CentralDePedidos.Infra.Data.Repositories;

public class ProdutoRepository : BaseRepository<Produto, Guid>, IProdutoRepository
{
    private readonly DataContext? _dataContext;

    public ProdutoRepository(DataContext? dataContext) : base(dataContext)
    {
        _dataContext = dataContext;
    }
}