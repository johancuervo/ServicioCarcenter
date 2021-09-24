using System;
using System.Collections.Generic;

#nullable disable

namespace Carcenter.Models.DB
{
    public partial class Mantenimiento
    {
        public Mantenimiento()
        {
            MantenimientosFacturas = new HashSet<MantenimientosFactura>();
        }

        public int Id { get; set; }
        public string Estado { get; set; }
        public int IdRepuestosUsados { get; set; }
        public int IdServicios { get; set; }

        public virtual RepuestosUsado IdRepuestosUsadosNavigation { get; set; }
        public virtual Servicio IdServiciosNavigation { get; set; }
        public virtual ICollection<MantenimientosFactura> MantenimientosFacturas { get; set; }
    }
}
