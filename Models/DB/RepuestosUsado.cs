using System;
using System.Collections.Generic;

#nullable disable

namespace Carcenter.Models.DB
{
    public partial class RepuestosUsado
    {
        public RepuestosUsado()
        {
            Mantenimientos = new HashSet<Mantenimiento>();
        }

        public int Id { get; set; }
        public decimal PrecioUnidad { get; set; }
        public int NumeroUnidades { get; set; }
        public decimal Descuento { get; set; }

        public virtual ICollection<Mantenimiento> Mantenimientos { get; set; }
    }
}
