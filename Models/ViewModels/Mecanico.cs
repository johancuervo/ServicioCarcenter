using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ServicioCar.Models
{
    public class Mecanico:Persona
    {
        [Required]
        public String estado { get; set; }
        public Mecanico(string estado)
        {
            this.estado = estado;
        }

   
    }
}
