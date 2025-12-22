using ApiCatalogo.Context;
using ApiCatalogo.Models;
using ApiCatalogo.Pagination;
using ApiCatalogo.Repositories;
using System.Reflection.Metadata.Ecma335;

namespace ApiCatalogo.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {       

        public ProdutoRepository(AppDbContext context) : base(context)
        {
            
        }

        public IEnumerable<Produto> GetProdutos(ProdutosParameters produtosParams)
        {
            return GetAll()
                 .OrderBy(p => p.Nome)
                 .Skip((produtosParams.PageNumber - 1) * produtosParams.PageSize)
                 .Take(produtosParams.PageSize).ToList();

        }

        public IEnumerable<Produto> GetProdutosPorCategorias(int id)
        {
            return GetAll().Where(p => p.CategoriaId == id);
        }

    }
}
