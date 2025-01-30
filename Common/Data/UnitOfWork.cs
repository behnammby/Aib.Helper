using Microsoft.EntityFrameworkCore;
using Behnammby.Common.Abstractions;

namespace Behnammby.Common.Data
{
    public abstract class UnitOfWork : IUnitOfWork
    {
        protected DbContext Context {get; set;}
        
        public UnitOfWork(DbContext context)
        {
            Context = context;
        }

        public int Complete()
        {
            return Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}