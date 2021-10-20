using Catalogo.Domain.Entities;
using Catalogo.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Catalogo.Infrastructure.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : EntityBase
    {
        protected AppDbContext Context;

        protected Repository(AppDbContext context)
        {
            Context = context;
        }

        public async Task Add(T entity)
        {
            await Context.Set<T>().AddAsync(entity);
        }

        public Task Delete(T entity)
        {
            Context.Set<T>().Remove(entity);
            return Task.CompletedTask;
        }

        public Task Update(T entity)
        {
            Context.Set<T>().Update(entity);
            return Task.CompletedTask;
        }

        public IQueryable<T> Get()
        {
            return Context.Set<T>().AsNoTracking();
        }

        public async Task<T> GetById(Expression<Func<T, bool>> predicate)
        {
            return await Context.Set<T>().AsNoTracking().FirstOrDefaultAsync(predicate);
        }
    }
}
