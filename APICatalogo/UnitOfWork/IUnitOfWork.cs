using ApiCatalogo.Repositories;

namespace ApiCatalogo.UnitOfWork
{
    public interface IUnitOfWork
    {
        IProdutoRepository ProdutoRepository { get;}
        ICategoriaRepository CategoriaRepository { get;}
        void Commit();
    }
}
