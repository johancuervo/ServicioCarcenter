using System;
using System.Collections.Generic;

#nullable disable

namespace Carcenter.Models.DB
{
    public partial class Tiendum
    {
        public Tiendum()
        {
            ProductoTienda = new HashSet<ProductoTiendum>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Ciudad { get; set; }

        public virtual ICollection<ProductoTiendum> ProductoTienda { get; set; }
    }
}
