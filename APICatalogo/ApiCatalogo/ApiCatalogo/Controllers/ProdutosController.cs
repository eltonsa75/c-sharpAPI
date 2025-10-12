using ApiCatalogo.Context;
using ApiCatalogo.Models;
using ApiCatalogo.Repositories;
using ApiCatalogo.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiCatalogo.Controllers
{
    [Route("api/[controller]")] // Produtos
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IRepository<Produto> _repository;
        

        public ProdutosController(IRepository<Produto> repository,
            IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
            _repository = repository;


        }

        [HttpGet("produtos/{id}")]

        public ActionResult<IEnumerable<Produto>> GetProdutosPorCategoria(int id)
        {
            var produtos = _produtoRepository.GetProdutosPorCategorias(id);
            if (produtos is null)
            {
                return NotFound($"Não existem produtos para a categoria de id = {id}");
            }
            return Ok(produtos);
        }

        // GET: api/Produtos
        [HttpGet]
        public ActionResult<IEnumerable<Produto>> Get()
        {
            var produtos = _repository.GetAll();
            if (produtos is null)
            {
                return NotFound();
            }
            return Ok (produtos);
        }

        // GET: api/Produtos/1

        [HttpGet("{id}", Name = "ObterProduto")]

        public ActionResult<Produto> Get(int id)
        {
            var produto = _repository.Get(c=> c.ProdutoId == id);
             if (produto is null)
            {     
                return NotFound($"Produto com id= {id} não encontrado...");
            }
             return Ok(produto);
        }

        // POST: api/Produtos
        [HttpPost]
        public ActionResult Post(Produto produto)
        {
            if (produto is null)
            {
                return BadRequest();
            }
            
           var novoProduto = _repository.Create(produto);
            
            return new CreatedAtRouteResult("ObterProduto",
                new { id = novoProduto.ProdutoId }, novoProduto);

        }

        [HttpPut("{id:int}")]
        public  ActionResult Put(int id, Produto produto)
        {
           if(id != produto.ProdutoId)
            {
                return BadRequest();
            }
           
           var produtoAtualizado = _repository.Update(produto);

          return Ok(produtoAtualizado);

        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
          var produto = _repository.Get(p=> p.ProdutoId == id);
            if (produto is null)
            {
                return NotFound("Produto Nao encontrado");
            }
           
              var produtoDeletado = _repository.Delete(produto);
            return Ok(produtoDeletado);
        }   

    }
}
