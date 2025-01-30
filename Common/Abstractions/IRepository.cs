using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Behnammby.Common.Abstractions
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        TEntity GetById(int id);
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        void Update(TEntity entity);
        void Remove(TEntity entity);
    }

}