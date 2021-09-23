using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicioCar.Models
{
    public class Cliente : Persona
    {
        public Cliente()
        {
        }

        public Cliente(int id, string tipoDocumento, int documento, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, int celular, string direccion, string correo) : base(id, tipoDocumento, documento, primerNombre, segundoNombre, primerApellido, segundoApellido, celular, direccion, correo)
        {
        }
    }
}
