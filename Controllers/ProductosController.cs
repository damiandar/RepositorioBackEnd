using Repositorio.Models;
using Repositorio.Repositorios;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Repositorio.Controllers
{
    public class ProductosController : ControladorBase<Producto>
    {
        public ProductoRepositorio<RepositorioDbContext> context { get; set; }
        public ProductosController(ProductoRepositorio<RepositorioDbContext> _repo) : base(_repo) {
            this.context = _repo;
        }
        [HttpGet]
        [Route("ListadoRopa")]
        public List<Producto> MostrarRopa() {
            return _repo.FindAll().Where(x => x.Categoria.Id == 1).ToList();
        }
        [HttpGet]
        [Route("busquedanombre")]
        public List<Producto> BuscarPorNombre(string nombrebuscado)
        {
            return _repo.FindAll().Where(x => x.Nombre.ToLower().Contains(nombrebuscado.ToLower() )).ToList();
        }
        

    }
}