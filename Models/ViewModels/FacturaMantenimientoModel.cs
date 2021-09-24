using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Carcenter.Models.ViewModels
{
    public class FacturaMantenimientoModel
    {
        [Required]
        public int id { get; set; }
        [Required]
        public FacturaModel factura { get; set; }
        [Required]
        public MantenimientoModel mantenimiento { get; set; }
    }
}
