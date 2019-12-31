using System;
using System.Data.Entity;
using System.Linq;
using DataLayer;

namespace ServicesLayer
{
    public class CrudRepository
    {
        protected readonly MainContext Context;

        public CrudRepository()
        {
            Context = new MainContext();
        }

        public void Save()
        {
            try
            {
                Context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IQueryable<T> GetItems<T>() where T : class
        {
            return Context.Set<T>();
        }

        public Object GetItemById(Type entityType, params object[] ids)
        {
            return Context.Set(entityType).Find(ids);
        }
        public T GetItemById<T>(params object[] ids)
        {
            return (T)GetItemById(typeof(T), ids);
        }

        public void Add<T>(T entity) where T : class
        {
            AddWithoutSave(entity);
            Save();
        }

        public void AddWithoutSave<T>(T entity) where T : class
        {
            Context.Set<T>().Add(entity);
        }

        public void Update<T>(T inItem) where T : class
        {
            if (inItem == null)
            {
                return;
            }
            Context.Entry(inItem).State = EntityState.Modified;

            Save();
        }

        public void Delete<T>(T entity) where T : class
        {
            Context.Set<T>().Remove(entity);

            Save();
        }
    }
}
