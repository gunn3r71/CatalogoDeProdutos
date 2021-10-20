using Catalogo.API.Data;
using Catalogo.API.Models;
using Catalogo.API.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Catalogo.API.Data.Repositories
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
