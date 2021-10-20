using Catalogo.API.Models;
using System.Collections.Generic;

namespace Catalogo.API.Repositories
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        IEnumerable<Produto> GetProdutosPorPreco();
    }
}
