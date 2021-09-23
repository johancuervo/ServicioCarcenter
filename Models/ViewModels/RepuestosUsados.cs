using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ServicioCar.Models
{
    
    public class RepuestosUsados
    {

        [Required]
        public int id { get; set; }
        [Required]
        public Decimal precioUnidad { get; set; }
        [Required]
        public int numeroUnidades { get; set; }
        [Required]
        public Decimal descuento { get; set; }
        public RepuestosUsados()
        {

        }

        public RepuestosUsados(int id, decimal precioUnidad, int numeroUnidades, decimal descuento)
        {
            this.id = id;
            this.precioUnidad = precioUnidad;
            this.numeroUnidades = numeroUnidades;
            this.descuento = descuento;
        }



    }
}
