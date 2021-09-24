using System;
using System.Collections.Generic;

#nullable disable

namespace Carcenter.Models.DB
{
    public partial class Producto
    {
        public Producto()
        {
            ProductoTienda = new HashSet<ProductoTiendum>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }

        public virtual ICollection<ProductoTiendum> ProductoTienda { get; set; }
    }
}
