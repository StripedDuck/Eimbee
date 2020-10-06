using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Eimbee.DataAccessLayer.Repository
{
    public abstract class Repository<T> : IRepository<T> where T : class, new()
    {
        protected DatabaseContext Context;

        protected Repository(DatabaseContext context)
        {
            Context = context;
        }

        public virtual async Task<T> InsertAsync(T entity)
        {
            Context.Set<T>().Add(entity);
            await Context.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<T> UpdateAsync(T entity)
        {
            Context.Set<T>().Update(entity);
            await Context.SaveChangesAsync();
            return entity;
        }

        public virtual async Task DeleteAsync(T entity)
        {
            Context.Set<T>().Remove(entity);
            await Context.SaveChangesAsync();
        }

        public virtual async Task DeleteAsync(IQueryable<T> entities)
        {
            Context.Set<T>().RemoveRange(entities);
            await Context.SaveChangesAsync();
        }

        public virtual async Task<List<T>> GetAllAsync()
        {
            return await Context.Set<T>().ToListAsync<T>();
        }

        public virtual IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = Context.Set<T>().Where(predicate);
            return query;
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
