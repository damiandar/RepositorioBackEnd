using System.Collections.Generic;
using System.Linq;

namespace Repositorio.Repositorios
{
    public interface IRepository<T>
    {
        void Crear(T entidad);
        void Actualizar(T entidad);

        void Borrar(int id);

        List<T> FindAll();
        T FindById(int id);

    }
}