using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Carcenter.Models.ViewModels
{
    public class ProductoModel
    {
        [Required]
        public int id { get; set; }
        [Required]
        public String descripcion { get; set; }
        [Required]
        public decimal precio { get; set; }

        public ProductoModel(int id, string descripcion, decimal precio)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.precio = precio;
        }
    }
}
