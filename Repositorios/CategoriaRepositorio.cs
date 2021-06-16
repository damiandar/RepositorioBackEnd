using Repositorio.Models;
using Microsoft.EntityFrameworkCore;

namespace Repositorio.Repositorios
{
    public class CategoriaRepositorio<TContext> : RepositoryBase<Categoria,TContext> where TContext : DbContext
    {
        public CategoriaRepositorio(TContext context):base(context){
            
        }
    }
}