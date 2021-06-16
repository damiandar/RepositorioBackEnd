using Microsoft.AspNetCore.Mvc;
using Repositorio.Models;
using System.Collections.Generic;
using Repositorio.Repositorios;
using System.Linq;

namespace Repositorio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class ControladorBase<T> :ControllerBase where T :BaseModelos
    {

        protected IRepository<T> _repo {get;set;}
        public ControladorBase(IRepository<T> repo){
            this._repo=repo;
        }
        
    [HttpGet]
    public virtual ActionResult<List<T>> GetTodos(){
        if(!ModelState.IsValid) return BadRequest();
        var resultado= _repo.FindAll();
        if(resultado==null) return NotFound();
            return Ok( resultado.ToList());

    }


    [HttpGet("{id}")]
    public virtual ActionResult<T> GetPorId(int id){
         if(!ModelState.IsValid) return BadRequest();
        var resultado=_repo.FindById(id);
        if(resultado==null) return NotFound();
         return Ok(resultado);
    }

    [HttpPost]
    public virtual ActionResult Post(T entidad){
        if(!ModelState.IsValid) return BadRequest();
        _repo.Crear(entidad);
        return Ok();
    }

    [HttpPut]
    public virtual ActionResult Put(T entidad){
        if(!ModelState.IsValid) return BadRequest();
        _repo.Actualizar(entidad);
        return Ok();
    }

        [HttpDelete("{id}")]
        public virtual ActionResult Delete(int id)
        {
            if (!ModelState.IsValid) return BadRequest();
            _repo.Borrar(id);
            return Ok();
        }





    }
}