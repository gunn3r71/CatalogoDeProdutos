using Catalogo.API.Models;
using System.Collections.Generic;

namespace Catalogo.API.Repositories
{
    public interface ICategoriaRepository : IRepository<Categoria>
    {
        IEnumerable<Categoria> GetCategoriasProdutos();
    }
}
