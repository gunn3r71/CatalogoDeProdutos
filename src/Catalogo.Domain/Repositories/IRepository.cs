using Catalogo.Domain.Entities;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Catalogo.Domain.Repositories
{
    public interface IRepository<T> where T : EntityBase
    {
        IQueryable<T> Get();

        Task<T> GetById(Expression<Func<T, bool>> predicate);

        Task Add(T entity);

        Task Update(T entity);

        Task Delete(T entity);
    }
}
