using Catalogo.API.Models;
using Catalogo.Domain.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace Catalogo.API.Controllers
{
    /// <summary>
    /// Controller de categorias
    /// </summary>
    [Route("api/v1/[Controller]")]
    public class CategoriasController : BaseController
    {
        //private readonly IUnitOfWork _unitOfWork;
        //private readonly IConfiguration _configuration;

        //public CategoriasController(IUnitOfWork unitOfWork, IConfiguration config)
        //{
        //    _unitOfWork = unitOfWork;
        //    _configuration = config;
        //}

        ///// <summary>
        ///// Lista produtos por categoria
        ///// </summary>
        ///// <returns>Lista de produtos por categoria</returns>
        //[HttpGet("produtos")]
        //[ProducesResponseType(statusCode: StatusCodes.Status200OK, Type = typeof(IEnumerable<Categoria>))]
        //public IActionResult GetCategoriasProdutos()
        //{
        //    var categorias = _unitOfWork.CategoriaRepository.GetCategoriasProdutos();
        //    return Ok(categorias);
        //}

        ///// <summary>
        ///// Lista categorias
        ///// </summary>
        ///// <returns>Lista de categorias</returns>
        //[HttpGet]
        //[ProducesResponseType(statusCode: StatusCodes.Status200OK, Type = typeof(IEnumerable<Categoria>))]
        //public IActionResult Get()
        //{
        //    var categorias = _unitOfWork.CategoriaRepository.Get().ToList();
        //    return Ok(categorias);
        //}

        ///// <summary>
        ///// Obtem categoria por id
        ///// </summary>
        ///// <param name="id">id da categoria a ser buscada</param>
        ///// <returns>Categoria</returns>
        //[HttpGet("{id:int}", Name = "ObterCategoria")]
        //[ProducesResponseType(statusCode: StatusCodes.Status200OK, Type = typeof(Categoria))]
        //[ProducesResponseType(statusCode: StatusCodes.Status404NotFound)]
        //public IActionResult Get(int id)
        //{
        //    var categoria = _unitOfWork.CategoriaRepository.GetById(x => x.CategoriaId == id);

        //    if (categoria == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(categoria);
        //}

        ///// <summary>
        ///// Cria uma categoria
        ///// </summary>
        ///// <param name="categoria">Modelo de categoria a ser criada</param>
        ///// <returns>Endereço da categoria criada</returns>
        //[HttpPost]
        //[ProducesResponseType(statusCode: StatusCodes.Status201Created)]
        //[ProducesResponseType(statusCode: StatusCodes.Status400BadRequest)]
        //public IActionResult Post([FromBody] Categoria categoria)
        //{
        //    _unitOfWork.CategoriaRepository.Add(categoria);
        //    _unitOfWork.Commit();

        //    return CreatedAtAction("ObterCategoria",
        //        new { id = categoria.CategoriaId });
        //}

        ///// <summary>
        ///// Atualiza uma categoria
        ///// </summary>
        ///// <param name="id">id da categoria a ser atualizada</param>
        ///// <param name="categoria">Modelo de categoria a ser atualizada</param>
        ///// <returns></returns>
        //[HttpPut("{id:int}")]
        //[ProducesResponseType(statusCode: StatusCodes.Status204NoContent)]
        //[ProducesResponseType(statusCode: StatusCodes.Status400BadRequest)]
        //public IActionResult Put(int id, [FromBody] Categoria categoria)
        //{
        //    if (id != categoria.CategoriaId)
        //    {
        //        return BadRequest(categoria);
        //    }

        //    _unitOfWork.CategoriaRepository.Update(categoria);
        //    _unitOfWork.Commit();

        //    return NoContent();
        //}

        ///// <summary>
        ///// Deleta uma categoria
        ///// </summary>
        ///// <param name="id">Id da categoria a ser deletada</param>
        ///// <returns></returns>
        //[HttpDelete("{id:int}")]
        //[ProducesResponseType(statusCode: StatusCodes.Status204NoContent)]
        //[ProducesResponseType(statusCode: StatusCodes.Status400BadRequest)]
        //public IActionResult Delete(int id)
        //{
        //    var categoria = _unitOfWork.CategoriaRepository.GetById(p => p.CategoriaId == id);

        //    if (categoria == null)
        //    {
        //        return NotFound();
        //    }
        //    _unitOfWork.CategoriaRepository.Delete(categoria);
        //    _unitOfWork.Commit();

        //    return NoContent();
        //}
    }
}

