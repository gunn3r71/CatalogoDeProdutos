using Catalogo.Domain.Entities;
using Catalogo.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Catalogo.Infrastructure.Repositories
{
    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(AppDbContext context) : base(context)
        {
        }

        public IEnumerable<Categoria> GetCategoriasProdutos()
        {
            return Get().Include(x => x.Produtos);
        }
    }
}
