using System;
using System.Collections.Generic;

#nullable disable

namespace Carcenter.Models.DB
{
    public partial class ProductoTiendum
    {
        public ProductoTiendum()
        {
            ProductoTiendaFacturas = new HashSet<ProductoTiendaFactura>();
        }

        public int Id { get; set; }
        public int ProductoIdProducto { get; set; }
        public int TiendaIdTienda { get; set; }

        public virtual Producto ProductoIdProductoNavigation { get; set; }
        public virtual Tiendum TiendaIdTiendaNavigation { get; set; }
        public virtual ICollection<ProductoTiendaFactura> ProductoTiendaFacturas { get; set; }
    }
}
