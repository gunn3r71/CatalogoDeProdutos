using Catalogo.API.Data;
using Catalogo.API.Models;
using Catalogo.API.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Catalogo.API.Data.Repositories
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(AppDbContext context) : base(context)
        {
        }

        public IEnumerable<Produto> GetProdutosPorPreco()
        {
            return Get().ToList().OrderBy(x => x.Preco);
        }
    }
}
