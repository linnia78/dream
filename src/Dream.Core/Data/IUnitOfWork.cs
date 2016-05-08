using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Storage;

namespace Dream.Core
{
    public interface IUnitOfWork<TContext> where TContext : DbContext
    {
        int Save();
        Task<int> SaveAsync();
        IRelationalTransaction BeginTransaction();
        Task<IRelationalTransaction> BeginTransactionAsync();
    }
}
