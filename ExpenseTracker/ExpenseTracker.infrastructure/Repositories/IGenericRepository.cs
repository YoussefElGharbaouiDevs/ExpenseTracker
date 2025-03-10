using ExpenseTracker.infrastructure.Common;

namespace ExpenseTracker.infrastructure.Repositories;

public interface IGenericRepository<T> where T : BaseEntity
{
    Task<IEnumerable<T>> GetAllAsync();

    Task<IQueryable<T>> FetchAllAsync();

    Task<T?> GetByIdAsync(int entityId);

    Task<T> AddAsync(T entity);

    Task UpdateAsync(T entity);

    Task DeleteAsync(T entity);
}