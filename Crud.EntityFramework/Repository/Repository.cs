using System.Linq.Expressions;
using Crud.Core.Help;
using Crud.EntityFramework.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Crud.EntityFramework.Repository;

public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity<int>
{
    private readonly ICrudDbContext _context;
    private readonly DbSet<TEntity> _set;

    protected Repository(DbSet<TEntity> set, ICrudDbContext context)
    {
        _context = context;
        _set = set;
    }

    public virtual async Task<TEntity> GetAsync(int id)
    {
        return await _set.FirstOrDefaultAsync(entity => entity.Id == id) ??
               throw new ArgumentException($"Entity with provided ID = {id} does not exist");
    }

    public virtual Task<IQueryable<TEntity>> GetAsync()
    {
        return Task.FromResult(_set.AsQueryable());
    }

    public virtual async Task<TEntity> CreateAsync(TEntity entity)
    {
        var entry = await _set.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entry.Entity;
    }

    public virtual async Task<TEntity> UpdateAsync(TEntity entity)
    {
        var entry = _set.Update(entity);
        await _context.SaveChangesAsync();
        return entry.Entity;
    }

    public virtual async Task DeleteAsync(int id)
    {
        _set.Remove(await _set.FirstOrDefaultAsync(entity => entity.Id == id) ??
                    throw new ArgumentException($"Entity with provided ID = {id} does not exist"));
        await _context.SaveChangesAsync();
    }
}