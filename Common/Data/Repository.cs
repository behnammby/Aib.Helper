using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Behnammby.Common.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Behnammby.Common.Data
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected DbContext Context {get; private set;}

        public Repository(DbContext context)
        {
            Context = context;    
        }

        public void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Where(predicate);
        }

        public TEntity GetById(int id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }

        public void Update(TEntity entity)
        {
            Context.Set<TEntity>().Update(entity);
        }
    }
}