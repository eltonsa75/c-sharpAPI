using ApiCatalogo.Models;
using ApiCatalogo.Repositories;

namespace ApiCatalogo.Repository
{
    public interface IProdutoRepository : IRepository<Produto>
    {
       IEnumerable<Produto> GetProdutosPorCategorias(int id);
    }
}
