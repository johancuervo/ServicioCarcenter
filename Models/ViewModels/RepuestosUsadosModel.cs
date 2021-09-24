using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Carcenter.Models.ViewModels
{
    public class RepuestosUsadosModel
    {
        [Required]
        public int id { get; set; }
        [Required]
        public Decimal precioUnidad { get; set; }
        [Required]
        public int numeroUnidades { get; set; }
        [Required]
        public Decimal descuento { get; set; }
        public RepuestosUsadosModel()
        {

        }

        public RepuestosUsadosModel(int id, decimal precioUnidad, int numeroUnidades, decimal descuento)
        {
            this.id = id;
            this.precioUnidad = precioUnidad;
            this.numeroUnidades = numeroUnidades;
            this.descuento = descuento;
        }
    }
}
