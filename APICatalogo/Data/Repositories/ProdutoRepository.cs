using ApiCatalogo.Repositories;
using APICatalogo.Models;
using System.Collections.Generic;
using System.Linq;

namespace ApiCatalogo.Data.Repositories
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
