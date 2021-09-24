using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Carcenter.Models.ViewModels
{
    public class FacturaModel
    {
        [Required]
        public int id { get; set; }
        [Required]
        public DateTime fecha { get; set; }
        [Required]
        public Decimal total { get; set; }
        [Required]
        public ClienteModel cliente { get; set; }
        [Required]
        public MecanicoModel mecanico { get; set; }
    }
}
