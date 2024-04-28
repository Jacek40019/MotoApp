namespace MotoApp.Repository;

using MotoApp.Entities;

public interface IReadRepository<out T> where T : class, IEntity
{
    IEnumerable<T> GetAll();

    T GetById(int id);
}
