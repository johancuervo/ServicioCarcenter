using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ServicioCar.Models
{
    public class Persona
    {
        [Required]
        public int id { get; set; }
        [Required]
        [StringLength(50)]
        public String tipoDocumento { get; set; }
        [Required]
        public int documento { get; set; }
        [Required]
        [StringLength(50)]
        public String primerNombre { get; set; }
        public String segundoNombre { get; set; }
        [Required]
        [StringLength(50)]
        public String primerApellido { get; set; }
        [Required]
        [StringLength(50)]
        public String segundoApellido { get; set; }
        [Required]
        public int celular { get; set; }
        [Required]
        [StringLength(50)]
        public String direccion { get; set; }
        [Required]
        [StringLength(50)]
        public String correo { get; set; }

        public Persona(int id, string tipoDocumento, int documento, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, int celular, string direccion, string correo)
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

        public Persona()
        {

        }
    }
}
