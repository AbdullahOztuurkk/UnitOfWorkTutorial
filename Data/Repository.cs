using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UnitOfWorkApp.Entities;

namespace UnitOfWorkApp.Data
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T Get(Expression<Func<T, bool>> predicate);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(int id);
    }

    public class Repository<T>:IRepository<T> where T: BaseEntity
    {
        private UoWContext context;
        public Repository(UoWContext context)
        {
            this.context = context;
        }
        public IEnumerable<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public T Get(Expression<Func<T, bool>> predicate)
        {
            return context.Set<T>().SingleOrDefault(predicate);
        }

        public void Add(T entity)
        {
            var currentEntity = context.Entry(entity);
            currentEntity.State = EntityState.Added;
        }

        public void Update(T entity)
        {
            var currentEntity = context.Entry(entity);
            currentEntity.State = EntityState.Modified;

        }

        public void Delete(T entity)
        {
            var currentEntity = context.Entry(entity);
            currentEntity.State = EntityState.Deleted;
        }

        public void Delete(int id)
        {
            var currentEntity = context.Set<T>().SingleOrDefault(z => z.Id == id);
            context.Set<T>().Remove(currentEntity);
        }
    }
}
