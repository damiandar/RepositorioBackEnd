using System.ComponentModel.DataAnnotations.Schema;

namespace Repositorio.Models
{
    public abstract class BaseModelos
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id {get;set;}
    }
}