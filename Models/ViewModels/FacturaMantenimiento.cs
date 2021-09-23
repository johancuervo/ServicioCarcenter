using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using ServicioCar.Models;

namespace Carcenter.Models
{
    public class FacturaMantenimiento
    {
        [Required]
        public int id { get; set; }
       [Required]
        public Factura factura { get; set; }
        [Required]
        public Mantenimiento mantenimiento { get; set; }
    }
}
