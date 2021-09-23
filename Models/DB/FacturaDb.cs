using System;
using System.Collections.Generic;

#nullable disable

namespace ServicioCar.Models.DB
{
    public partial class FacturaDb
    {
        public int Id { get; set; }
        public DateTime FechaFactura { get; set; }
        public decimal TotalFactura { get; set; }
        public int IdClientes { get; set; }
        public int IdMecanicos { get; set; }

        public virtual ClienteDb IdClientesNavigation { get; set; }
        public virtual MecanicoDb IdMecanicosNavigation { get; set; }
    }
}
