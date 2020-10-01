using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AppSystem.Repository
{
    public interface IRepository<T> where T : class, new()
    {
        T Add(T model);
        bool Update(T model);
        List<T> Get<TKey>(Expression<Func<T, TKey>> orderBy);
        List<TResult> Get<TKey, TResult>
        (
            Expression<Func<T, TKey>> orderBy,
            Expression<Func<T, bool>> where,
            Expression<Func<T, TResult>> select
        );
        T GetOne(Expression<Func<T, bool>> where);
        int Save();
    }
}
