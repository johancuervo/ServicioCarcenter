using System;
using System.Collections.Generic;

#nullable disable

namespace Carcenter.Models.DB
{
    public partial class Servicio
    {
        public Servicio()
        {
            Mantenimientos = new HashSet<Mantenimiento>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioManoObraMin { get; set; }
        public string PrecioManoObraMax { get; set; }
        public decimal Descuento { get; set; }

        public virtual ICollection<Mantenimiento> Mantenimientos { get; set; }
    }
}
