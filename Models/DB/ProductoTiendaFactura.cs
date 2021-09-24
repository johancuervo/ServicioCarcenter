using System;
using System.Collections.Generic;

#nullable disable

namespace Carcenter.Models.DB
{
    public partial class ProductoTiendaFactura
    {
        public int Id { get; set; }
        public int ProductoTiendaId { get; set; }
        public int ProductoTiendaProductoIdProducto { get; set; }
        public int ProductoTiendaTiendaIdTienda { get; set; }
        public int FacturasId { get; set; }
        public int FacturasIdClientes { get; set; }
        public int FacturasIdMecanicos { get; set; }

        public virtual Factura Facturas { get; set; }
        public virtual ProductoTiendum ProductoTienda { get; set; }
    }
}
