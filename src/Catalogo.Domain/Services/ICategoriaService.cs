using Catalogo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Catalogo.Domain.Services
{
    public interface ICategoriaService : IService<Categoria>
    {
        IList<Categoria> ListarCategorias();

        Categoria BuscarCategoriaPorId(Guid id);

        Task AdicionarCategoria(Categoria entity);

        Task AtualizarCategoria(Categoria entity);

        Task DeletarCategoria(Categoria entity);
    }
}
