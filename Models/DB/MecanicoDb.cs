using System;
using System.Collections.Generic;

#nullable disable

namespace ServicioCar.Models.DB
{
    public partial class MecanicoDb
    {
        public MecanicoDb()
        {
            Facturas = new HashSet<FacturaDb>();
        }

        public int Id { get; set; }
        public string TipoDocumento { get; set; }
        public int Documento { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public int Celular { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string Estado { get; set; }

        public virtual ICollection<FacturaDb> Facturas { get; set; }
    }
}
