using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ServicioCar.Models
{
    public class Factura
    {
        [Required]
        public int id { get; set; }
        [Required]
        public DateTime fecha { get; set; }
        [Required]
        public Decimal total { get; set; }
        [Required]
        public Cliente cliente { get; set; }
        [Required]
        public Mecanico mecanico { get; set; }
    }
}
