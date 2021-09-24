using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Carcenter.Models.ViewModels
{
    public class TiendaModel
    {
        [Required]
        public int id { get; set; }
        [Required]
        public String nombre { get; set; }
        [Required]
        public String Ciudad { get; set; }

        public TiendaModel(int id, string nombre, string ciudad)
        {
            this.id = id;
            this.nombre = nombre;
            Ciudad = ciudad;
        }
    }
}
