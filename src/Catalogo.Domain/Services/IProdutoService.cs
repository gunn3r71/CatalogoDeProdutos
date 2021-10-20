using Catalogo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Catalogo.Domain.Services
{
    public interface IProdutoService : IService<Produto>
    {
        IList<Produto> Get();

        Produto GetById(Guid id);

        Task Add(Produto entity);

        Task Update(Produto entity);

        Task Delete(Produto entity);
    }
}
