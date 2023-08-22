using movies.core.Entities.Base;

namespace movies.core.Repositories.Base;

public interface IRepository<T> where T:Entity
{
    Task<IReadOnlyList<T>> GetAllAsync();
    Task<T> GetByIdAsync(int Id);
    Task<T> AddAsyncc(T entity);
    Task UpdateAsyncc(T entity);
    Task DeleteAsyncc(T entity);
}