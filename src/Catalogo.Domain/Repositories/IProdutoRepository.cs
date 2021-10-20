using Catalogo.Domain.Entities;
using System.Collections.Generic;

namespace Catalogo.Domain.Repositories
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        IEnumerable<Produto> GetProdutosPorPreco();
    }
}
