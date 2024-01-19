namespace CentralDePedidos.Domain.Interfaces.Repositories;

public interface IBaseRepository<TEntity, Tkey>
    where TEntity : class
{
    void Add(TEntity entity);
}