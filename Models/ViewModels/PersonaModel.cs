using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Carcenter.Models.ViewModels
{
    public class PersonaModel
    {
        public int id { get; set; }
        [StringLength(50)]
        public String tipoDocumento { get; set; }
        public int documento { get; set; }
        [StringLength(50)]
        public String primerNombre { get; set; }
        public String segundoNombre { get; set; }
        [StringLength(50)]
        public String primerApellido { get; set; }
        [StringLength(50)]
        public String segundoApellido { get; set; }
        public int celular { get; set; }
        [StringLength(50)]
        public String direccion { get; set; }
        [StringLength(50)]
        public String correo { get; set; }

        public PersonaModel(int id, string tipoDocumento, int documento, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, int celular, string direccion, string correo)
        {
            this.id = id;
            this.tipoDocumento = tipoDocumento;
            this.documento = documento;
            this.primerNombre = primerNombre;
            this.segundoNombre = segundoNombre;
            this.primerApellido = primerApellido;
            this.segundoApellido = segundoApellido;
            this.celular = celular;
            this.direccion = direccion;
            this.correo = correo;
        }

        public PersonaModel()
        {

        }
    
}
}
