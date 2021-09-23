using System;
using System.Collections.Generic;

#nullable disable

namespace ServicioCar.Models.DB
{
    public partial class MantenimientoDb
    {
        public int Id { get; set; }
        public string Estado { get; set; }
        public int IdRepuestosUsados { get; set; }
        public int IdServicios { get; set; }

        public virtual RepuestosUsadoDb IdRepuestosUsadosNavigation { get; set; }
        public virtual ServicioDb IdServiciosNavigation { get; set; }
    }
}
