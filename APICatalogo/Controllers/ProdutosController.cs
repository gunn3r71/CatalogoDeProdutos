using ApiCatalogo.UnitOfWork;
using APICatalogo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ApiCatalogo.Controllers
{
    /// <summary>
    /// Controller de produtos
    /// </summary>
    [Route("api/v1/[Controller]")]
    public class ProdutosController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProdutosController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Lista produtos por preço
        /// </summary>
        /// <returns>Lista ordenada por preço</returns>
        [HttpGet("menorpreco")]
        public IActionResult GetProdutoPorPreco()
        {
            var produtos = _unitOfWork.ProdutoRepository.GetProdutosPorPreco();

            return Ok(produtos);
        }

        /// <summary>
        /// Lista produtos
        /// </summary>
        /// <returns>Lista de produtos</returns>
        // api/produtos
        [HttpGet]
        public IActionResult Get()
        {
            var produtos= _unitOfWork.ProdutoRepository.Get().ToList();
            return Ok(produtos);
        }   
        
        /// <summary>
        /// Obtem um produto por id
        /// </summary>
        /// <param name="id">id de produto a ser buscado</param>
        /// <returns>Produto</returns>
        // api/produtos/1
        [HttpGet("{id:int}", Name ="ObterProduto")]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK, Type = typeof(Produto))]
        [ProducesResponseType(statusCode: StatusCodes.Status404NotFound)]
        public IActionResult Get(int id )
        {
            var produto = _unitOfWork.ProdutoRepository.GetById(p => p.ProdutoId == id);

            if(produto == null)
            {
                return NotFound();
            }
            return Ok(produto);
        }

        /// <summary>
        /// Cria um produto
        /// </summary>
        /// <param name="produto">Modelo de produto a ser criado</param>
        /// <returns>Endereço do produto criado</returns>
        //  api/produtos
        [HttpPost]
        [ProducesResponseType(statusCode: StatusCodes.Status201Created, Type = typeof(Produto))]
        [ProducesResponseType(statusCode: StatusCodes.Status400BadRequest)]
        public IActionResult Post([FromBody]Produto produto)
        {
            _unitOfWork.ProdutoRepository.Add(produto);
            _unitOfWork.Commit();

            return CreatedAtRoute("ObterProduto",
                new { id = produto.ProdutoId }, produto);
        }

        /// <summary>
        /// Atualiza um produto
        /// </summary>
        /// <param name="id">Id do produto a ser atualizado</param>
        /// <param name="produto">Modelo do produto a ser atualizado</param>
        /// <returns></returns>
        // api/produtos/1
        [HttpPut("{id:int}")]
        [ProducesResponseType(statusCode: StatusCodes.Status204NoContent)]
        [ProducesResponseType(statusCode: StatusCodes.Status400BadRequest)]
        public IActionResult Put(int id,[FromBody] Produto produto)
        {
            if( id != produto.ProdutoId)
            {
                return BadRequest();
            }

            _unitOfWork.ProdutoRepository.Update(produto);
            return NoContent();
        }

        /// <summary>
        /// Delete um produto
        /// </summary>
        /// <param name="id">Id do produto a ser deletado</param>
        /// <returns></returns>
        //  api/produtos/1
        [HttpDelete("{id:int}")]
        [ProducesResponseType(statusCode: StatusCodes.Status204NoContent)]
        [ProducesResponseType(statusCode: StatusCodes.Status400BadRequest)]
        public IActionResult Delete(int id)
        {
            var produto = _unitOfWork.ProdutoRepository.GetById(p => p.ProdutoId == id);
            
            if (produto == null)
            {
                return NotFound();
            }

            _unitOfWork.ProdutoRepository.Delete(produto);
            _unitOfWork.Commit();
            return NoContent();
        }
    }
}