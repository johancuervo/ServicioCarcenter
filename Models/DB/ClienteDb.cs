using System;
using System.Collections.Generic;

#nullable disable

namespace ServicioCar.Models.DB
{
    public partial class ClienteDb
    {
        public ClienteDb()
        {
            Facturas = new HashSet<FacturaDb>();
        }

        public ClienteDb(int id, string tipoDocumento, int documento, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, int celular, string direccion, string correo, ICollection<FacturaDb> facturas)
        {
            Id = id;
            TipoDocumento = tipoDocumento;
            Documento = documento;
            PrimerNombre = primerNombre;
            SegundoNombre = segundoNombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            Celular = celular;
            Direccion = direccion;
            Correo = correo;
            //Facturas = facturas;
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

        public virtual ICollection<FacturaDb> Facturas { get; set; }
    }
}
