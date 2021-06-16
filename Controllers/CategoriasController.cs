using Repositorio.Models;
using Repositorio.Repositorios;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Repositorio.Controllers
{
    public class CategoriasController : ControladorBase<Categoria>
    {
        public CategoriaRepositorio<RepositorioDbContext> context { get; set; }
        public CategoriasController(CategoriaRepositorio<RepositorioDbContext> _repo) : base(_repo) {
            this.context = _repo;
        }
 


        
    }
}