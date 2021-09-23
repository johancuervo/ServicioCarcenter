using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ServicioCar.Models
{
    public class Mantenimiento
    {
     
        [Required]
        public int id { get; set; }
        [Required]
        public String estado { get; set; }
        [Required]
        public RepuestosUsados repuestosUsados { get; set; }
        [Required]
        public Servicio servicio { get; set; }

        public Mantenimiento()
        {

        }

        public Mantenimiento(int id, string estado, RepuestosUsados repuestosUsados, Servicio servicio)
        {
            this.id = id;
            this.estado = estado;
            this.repuestosUsados = repuestosUsados;
            this.servicio = servicio;
        }

    }
}
