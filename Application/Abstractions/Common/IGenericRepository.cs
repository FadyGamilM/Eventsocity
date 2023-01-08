namespace Eventsocity.Application.Abstractions.Common;

public interface IGenericRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAll();

    Task<T> GetById(int id);

    Task Create(T entity);

    Task Update (T entity, int id);

    Task Delete(int Id);
}