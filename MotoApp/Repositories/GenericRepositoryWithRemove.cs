namespace MotoApp.Repositories;

using MotoApp.Entities;

public class GenericRepositoryWithRemove<TEntity, TKey> : GenericRepository<TEntity, TKey> where TEntity : class, IEntity, new()
        where TKey : struct
{
    public void Remove(TEntity item)
    {
        _items.Remove(item);
    }

}
