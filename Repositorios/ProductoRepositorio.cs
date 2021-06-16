using System.Collections.Generic;
using System.Linq;
using Repositorio.Models;
using Microsoft.EntityFrameworkCore;

namespace Repositorio.Repositorios
{
    public class ProductoRepositorio<TContext> : RepositoryBase<Producto,TContext> where TContext : DbContext
    {
        public ProductoRepositorio(TContext context):base(context){
            
        }
        public override Producto FindById(int id)
        {
            return Incluir().Where(p=>p.Id==id).FirstOrDefault();
        }
        public override List<Producto> FindAll(){
            return Incluir().ToList();
        }
         private IQueryable<Producto> Incluir(){
                return this.Db.Set<Producto>()
                .Include(p => p.Categoria );
        }
    }
}