using CentralDePedidos.Domain.Interfaces.Repositories;
using CentralDePedidos.Infra.Data.Contexts;

namespace CentralDePedidos.Infra.Data.Repositories;

public abstract class BaseRepository<TEntity, Tkey> : IBaseRepository<TEntity, TEntity>
    where TEntity : class
{
    private readonly DataContext? _dataContext;

    protected BaseRepository(DataContext? dataContext)
    {
        _dataContext = dataContext;
    }

    public virtual void Add(TEntity entity)
    {
        _dataContext.Add(entity);
    }
}