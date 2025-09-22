using ApiCatalogo.Context;
using ApiCatalogo.Models;
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
        private readonly IProdutoRepository _repository;
        

        public ProdutosController(IProdutoRepository repository, ILogger<ProdutosController> logger)
        {
            _repository = repository;
        
        }

        // GET: api/Produtos
        [HttpGet]
        public ActionResult<IEnumerable<Produto>> Get()
        {
            var produtos = _repository.GetProdutos().ToList();
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
            var produto = _repository.GetProduto(id);
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
           
           bool atualizado = _repository.Update(produto);

            if (atualizado)
            {
                return Ok(produto);
            }
            else
            {
                return StatusCode(500, $"Falha ao atualizar o produto de id = {id}");
            }

        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
          bool deletado = _repository.Delete(id);
            if (deletado)
            {
                return Ok($"Produto de id = {id} deletado com sucesso");
            }
            else
            {
                return StatusCode(500, $"Falha ao deletar o produto de id = {id}");
            }

        }   

    }
}
