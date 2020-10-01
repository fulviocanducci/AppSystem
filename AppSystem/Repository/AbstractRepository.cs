using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace AppSystem.Repository
{
    public abstract class AbstractRepository<T> : IRepository<T>
        where T : class, new()
    {
        internal Data.Database Database { get; }

        public AbstractRepository(Data.Database database)
        {
            Database = database;
        }

        protected void AddEntry(T model)
        {
            Database.Entry<T>(model).State = EntityState.Added;
        }
        protected void UpdateEntry(T model)
        {
            Database.Entry<T>(model).State = System.Data.Entity.EntityState.Modified;
        }

        protected void RemoveEntry(T model)
        {
            Database.Entry<T>(model).State = System.Data.Entity.EntityState.Detached;
        }

        public T Add(T model)
        {
            AddEntry(model);
            Save();
            RemoveEntry(model);
            return model;
        }

        public bool Update(T model)
        {
            UpdateEntry(model);
            bool status = Save() > 0;
            RemoveEntry(model);
            return status;
        }

        public List<T> Get<TKey>(Expression<Func<T, TKey>> orderBy)
        {
            return Database
                .Set<T>()
                .AsNoTracking()
                .OrderBy(orderBy)
                .ToList();
        }

        public T GetOne(Expression<Func<T, bool>> where)
        {
            return Database
                .Set<T>()
                .AsNoTracking()
                .Where(where)
                .FirstOrDefault();
        }
        
        public int Save()
        {
            return Database.SaveChanges();
        }

        public List<TResult> Get<TKey, TResult>(
            Expression<Func<T, TKey>> orderBy, 
            Expression<Func<T, bool>> where, 
            Expression<Func<T, TResult>> select)
        {
            return Database
                .Set<T>()
                .AsNoTracking()
                .OrderBy(orderBy)
                .Where(where)
                .Select(select)
                .ToList();
        }
    }
}
