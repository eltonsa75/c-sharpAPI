using ApiCatalogo.Interface;
using ApiCatalogo.Repository;

namespace ApiCatalogo.Repositories
{
    public interface IUnitOfWork
    {
        IProdutoRepository ProdutoRepository { get; }
        ICategoriaRepository CategoriaRepository { get; }
        void Commit();
    }
}
