 

namespace Repositorio.Models
{
    public class Producto: BaseModelos
    {
 
        public string Nombre{get;set;}

        public double Precio{get;set;}

        public int CategoriaId { get; set; }
       
        public virtual Categoria Categoria{get;set;}
    }
}