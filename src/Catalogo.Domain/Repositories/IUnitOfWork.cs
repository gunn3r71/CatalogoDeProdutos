using System.Threading.Tasks;

namespace Catalogo.Domain.Repositories
{
    public interface IUnitOfWork
    {
        IProdutoRepository ProdutoRepository { get; }
        ICategoriaRepository CategoriaRepository { get; }
        Task Commit();
    }
}
