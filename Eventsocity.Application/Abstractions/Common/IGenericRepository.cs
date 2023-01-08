namespace Eventsocity.Application.Abstractions.Common;

public interface IGenericRepository<T> where T : class
{
    IEnumerable<T> GetAll();

    T GetById(int id);

    Task Create(T entity);

    Task Update (T entity, int id);

    Task Delete(T Id);
}