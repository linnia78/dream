using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Dream.Core
{
    public abstract class Repository<TContext, TEntity> : IRepository<TContext, TEntity>, IDisposable
        where TContext : DbContext
        where TEntity : class
    {
        private readonly TContext _context;
        private readonly DbSet<TEntity> _dbSet;
        protected TContext Context { get { return this._context; } }
        public Repository(TContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException();
            }
            this._context = context;
            this._dbSet = this._context.Set<TEntity>();
        }

        //public IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, IEnumerable<Expression<Func<TEntity, object>>> includes = null)
        //{
        //    var query = this._dbSet
        //        .Where(filter);

        //    foreach(var include in includes)
        //    {
        //        query = query.Include(include);
        //    }
        //    return query;
        //}
        public Repository<TContext, TEntity> Insert(TEntity entity)
        {
            this._dbSet.Add(entity);
            return this;
        }

        public Repository<TContext, TEntity> Insert(IEnumerable<TEntity> entities)
        {
            this._dbSet.AddRange(entities);
            return this;
        }

        public Repository<TContext, TEntity> Update(TEntity entity)
        {
            this._context.Entry<TEntity>(entity).State = EntityState.Modified;
            return this;
        }

        public Repository<TContext, TEntity> Delete(TEntity entity)
        {
            this._dbSet.Remove(entity);
            return this;
        }

        public Repository<TContext, TEntity> Delete(IEnumerable<TEntity> entities)
        {
            this._dbSet.RemoveRange(entities);
            return this;
        }

        //Dispose
        private bool _disposed = false;
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing && _context != null)
                {
                    _context.Dispose();
                }
                this._disposed = true;
            }
        }

    }
}
