using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Repositorio.Models
{
    public class Categoria: BaseModelos
    {
     
        public string Descripcion {get;set;}
         [JsonIgnore]
        public virtual List<Producto> Productos {get;set;}
    }
}