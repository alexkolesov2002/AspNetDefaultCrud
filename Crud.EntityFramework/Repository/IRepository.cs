using System.Linq.Expressions;
using Crud.Core.Help;


namespace Crud.EntityFramework.Repository;

public interface IRepository<T> where T : class
{
    Task<T> GetAsync(int id);

    Task<IQueryable<T>> GetAsync();

    Task<T> CreateAsync(T entity);

    Task<T> UpdateAsync(T entity);

    Task DeleteAsync(int id);
}
