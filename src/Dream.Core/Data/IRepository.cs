using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Dream.Core
{
    public interface IRepository<TContext, TEntity>
        where TContext : DbContext
        where TEntity : class
    {
        //IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Expression<Func<TEntity, object>>[] includes = null);
        //Task<IQueryable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> filter = null, Expression<Func<TEntity, object>>[] includes = null);
    }
}
