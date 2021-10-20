using Catalogo.Domain.Entities;
using Catalogo.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Catalogo.Infrastructure.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : EntityBase
    {
        protected AppDbContext Context;

        protected Repository(AppDbContext context)
        {
            Context = context;
        }

        public void Add(T entity)
        {
            Context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            Context.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            Context.Set<T>().Update(entity);
        }

        public IQueryable<T> Get()
        {
            return Context.Set<T>().AsNoTracking();
        }

        public T GetById(Expression<Func<T, bool>> predicate)
        {
            return Context.Set<T>().AsNoTracking().FirstOrDefault(predicate);
        }
    }
}
