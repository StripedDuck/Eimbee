using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Eimbee.DataAccessLayer.Repository
{
    public interface IRepository<T> : IDisposable where T : class
    {
        Task<T> InsertAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task DeleteAsync(IQueryable<T> entity);
        Task<List<T>> GetAllAsync();
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
    }
}
