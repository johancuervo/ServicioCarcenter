using System;
using System.Collections.Generic;

#nullable disable

namespace Carcenter.Models.DB
{
    public partial class Factura
    {
        public Factura()
        {
            MantenimientosFacturas = new HashSet<MantenimientosFactura>();
            ProductoTiendaFacturas = new HashSet<ProductoTiendaFactura>();
        }

        public int Id { get; set; }
        public DateTime FechaFactura { get; set; }
        public decimal TotalFactura { get; set; }
        public int IdClientes { get; set; }
        public int IdMecanicos { get; set; }

        public virtual Cliente IdClientesNavigation { get; set; }
        public virtual Mecanico IdMecanicosNavigation { get; set; }
        public virtual ICollection<MantenimientosFactura> MantenimientosFacturas { get; set; }
        public virtual ICollection<ProductoTiendaFactura> ProductoTiendaFacturas { get; set; }
    }
}
