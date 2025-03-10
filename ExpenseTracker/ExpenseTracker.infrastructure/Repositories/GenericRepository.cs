using ExpenseTracker.infrastructure.Common;
using ExpenseTracker.infrastructure.Data.Migrations.SqlServer;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.infrastructure.Repositories;

public class GenericRepository<T>(ExpenseTrackerDbContext context) : IGenericRepository<T>
    where T : BaseEntity
{
    private readonly ExpenseTrackerDbContext _context = context ?? throw new ArgumentNullException(nameof(context));

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public Task<IQueryable<T>> FetchAllAsync()
    {
        var queryResult = _context.Set<T>().AsQueryable();
        return Task.FromResult(queryResult);
    }

    public async Task<T?> GetByIdAsync(int entityId)
    {
        return await _context.Set<T>().FindAsync(entityId);
    }

    public async Task<T> AddAsync(T entity)
    {
        var savedEntity = await _context.Set<T>().AddAsync(entity);
        await _context.SaveChangesAsync();
        return savedEntity.Entity;
    }

    public async Task UpdateAsync(T entity)
    {
        _context.Set<T>().Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(T entity)
    {
        _context.Set<T>().Remove(entity);
        await _context.SaveChangesAsync();
    }
}