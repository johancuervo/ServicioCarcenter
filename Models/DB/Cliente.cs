﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Carcenter.Models.DB
{
    public partial class Cliente
    {
        public Cliente()
        {
            Facturas = new HashSet<Factura>();
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

        public virtual ICollection<Factura> Facturas { get; set; }
    }
}
