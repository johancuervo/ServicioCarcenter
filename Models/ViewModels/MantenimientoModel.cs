using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Carcenter.Models.ViewModels
{
    public class MantenimientoModel
    {
        [Required]
        public int id { get; set; }
        [Required]
        public String estado { get; set; }
        [Required]
        public RepuestosUsadosModel repuestosUsados { get; set; }
        [Required]
        public ServicioModel servicio { get; set; }

        public MantenimientoModel()
        {

        }

        public MantenimientoModel(int id, string estado, RepuestosUsadosModel repuestosUsados, ServicioModel servicio)
        {
            this.id = id;
            this.estado = estado;
            this.repuestosUsados = repuestosUsados;
            this.servicio = servicio;
        }
    }
}
