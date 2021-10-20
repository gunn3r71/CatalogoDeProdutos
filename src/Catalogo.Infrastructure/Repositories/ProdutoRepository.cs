using Catalogo.Domain.Entities;
using Catalogo.Domain.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Catalogo.Infrastructure.Repositories
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
