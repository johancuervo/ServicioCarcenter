using System;
using System.Collections.Generic;

#nullable disable

namespace Carcenter.Models.DB
{
    public partial class MantenimientosFactura
    {
        public int Id { get; set; }
        public int MantenimientosId { get; set; }
        public int MantenimientosIdRepuestosUsados { get; set; }
        public int MantenimientosIdServicios { get; set; }
        public int FacturasId { get; set; }
        public int FacturasIdClientes { get; set; }
        public int FacturasIdMecanicos { get; set; }

        public virtual Factura Facturas { get; set; }
        public virtual Mantenimiento Mantenimientos { get; set; }
    }
}
