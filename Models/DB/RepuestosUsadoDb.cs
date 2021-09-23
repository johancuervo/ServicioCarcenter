using System;
using System.Collections.Generic;

#nullable disable

namespace ServicioCar.Models.DB
{
    public partial class RepuestosUsadoDb
    {
        public RepuestosUsadoDb()
        {
            Mantenimientos = new HashSet<MantenimientoDb>();
        }

        public int Id { get; set; }
        public decimal PrecioUnidad { get; set; }
        public int NumeroUnidades { get; set; }
        public decimal Descuento { get; set; }

        public virtual ICollection<MantenimientoDb> Mantenimientos { get; set; }
    }
}
