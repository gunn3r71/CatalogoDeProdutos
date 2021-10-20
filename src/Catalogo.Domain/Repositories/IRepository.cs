using Catalogo.Domain.Entities;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Catalogo.Domain.Repositories
{
    public interface IRepository<T> where T : EntityBase
    {
        IQueryable<T> Get();

        T GetById(Expression<Func<T, bool>> predicate);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
