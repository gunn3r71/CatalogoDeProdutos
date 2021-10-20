using Catalogo.Domain.Entities;
using System.Collections.Generic;

namespace Catalogo.Domain.Repositories
{
    public interface ICategoriaRepository : IRepository<Categoria>
    {
        IEnumerable<Categoria> GetCategoriasProdutos();
    }
}
