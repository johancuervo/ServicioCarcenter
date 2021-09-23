using System;
using System.Collections.Generic;

#nullable disable

namespace ServicioCar.Models.DB
{
    public partial class ServicioDb
    {
        public ServicioDb()
        {
            Mantenimientos = new HashSet<MantenimientoDb>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioManoObraMin { get; set; }
        public string PrecioManoObraMax { get; set; }
        public decimal Descuento { get; set; }

        public virtual ICollection<MantenimientoDb> Mantenimientos { get; set; }
    }
}
