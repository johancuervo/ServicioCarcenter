using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ServicioCar.Models
{
    public class Servicio
    {
        [Required]
        public int id { get; set; }
        public String descripcion { get; set; }
        [Required]
        public Decimal precioManoObramMin { get; set; }
        [Required]
        public Decimal precioManoObraMax { get; set; }
        [Required]
        public Decimal descuento { get; set; }

        public Servicio(int id, string descripcion, decimal precioManoObramMin, decimal precioManoObraMax, decimal descuento)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.precioManoObramMin = precioManoObramMin;
            this.precioManoObraMax = precioManoObraMax;
            this.descuento = descuento;
        }

        public Servicio()
        {
        }
    }
}
