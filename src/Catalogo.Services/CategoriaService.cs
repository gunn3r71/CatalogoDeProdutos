using Catalogo.Domain.Entities;
using Catalogo.Domain.Repositories;
using Catalogo.Domain.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Catalogo.Services
{
    public class CategoriaService : Service<Categoria>, ICategoriaService
    {
        public CategoriaService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task AdicionarCategoria(Categoria entity)
        {
            await _unitOfWork.CategoriaRepository.Add(entity);

        }

        public Task AtualizarCategoria(Categoria entity)
        {
            throw new NotImplementedException();
        }

        public Categoria BuscarCategoriaPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task DeletarCategoria(Categoria entity)
        {
            throw new NotImplementedException();
        }

        public IList<Categoria> ListarCategorias()
        {
            throw new NotImplementedException();
        }
    }
}
