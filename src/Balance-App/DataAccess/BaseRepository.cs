using Microsoft.EntityFrameworkCore;
using Balance_App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Balance_App.DataAccess
{
    public abstract class BaseRepository<T>
        where T : BaseEntity
    {
        protected DbContext Context { get; set; }
        protected DbSet<T> Items { get; set; }

        public BaseRepository()
        {
            Context = new MyDbContext();
            Items = Context.Set<T>();
        }

        public BaseRepository(UnitOfWork uow)
        {
            Context = uow.Context;
            Items = Context.Set<T>();
        }

        protected virtual IQueryable<T> CascadeInclude(IQueryable<T> query)
        {
            return query;
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null, bool cascadeInclude = false)
        {
            IQueryable<T> query = Items;

            if (filter != null)
                query = query.Where(filter);

            if (cascadeInclude)
                query = CascadeInclude(query);

            return query.ToList();
        }

        public List<TResult> GetReferences<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            return Items
                    .Where(filter)
                    .Select(selector)
                    .ToList();
        }

        public T GetById(int id, bool cascadeInclude = false)
        {
            IQueryable<T> query = Items;

            if (cascadeInclude)
                query = CascadeInclude(query);

            return query
                    .Where(i => i.Id == id)
                    .FirstOrDefault();
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter, bool cascadeInclude = false)
        {
            IQueryable<T> query = Items;

            if (cascadeInclude)
                query = CascadeInclude(query);

            return query
                      .Where(filter)
                      .FirstOrDefault();
        }

        public void Insert(T item)
        {
            Items.Add(item);
            Context.SaveChanges();
        }

        public void Update(T item)
        {
            Items.Update(item);
            Context.SaveChanges();
        }

        public void Delete(T item)
        {
            Items.Remove(item);
            Context.SaveChanges();
        }
    }
}
