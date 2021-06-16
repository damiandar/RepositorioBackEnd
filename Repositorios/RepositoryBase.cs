using Microsoft.EntityFrameworkCore;
using Repositorio.Models;
using System.Linq;
using System.Collections.Generic;

namespace Repositorio.Repositorios
{
    public abstract class RepositoryBase<T,TContext> : IRepository<T> where T : BaseModelos where TContext : DbContext
    {
        protected TContext Db{get;set;}

        public RepositoryBase(TContext context){
            Db=context;
        }
        public virtual void Actualizar(T entidad)
        {
            this.Db.Set<T>().Update(entidad);
            this.Db.SaveChanges();
        }

        public virtual void Crear(T entidad)
        {
            this.Db.Set<T>().Add(entidad);
            this.Db.SaveChanges();
        }

        public virtual void Borrar(int id)
        {
           var entidad = this.FindById(id);
           this.Db.Set<T>().Attach(entidad);
           this.Db.Set<T>().Remove(entidad);
           this.Db.SaveChanges();
        }

        public virtual List<T> FindAll()
        {
            return this.Db.Set<T>().ToList();
        }

        public virtual T FindById(int id)
        {
            return this.Db.Set<T>().Find(id);
        }


    }
}