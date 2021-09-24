using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Carcenter.Models.ViewModels
{
    public class MecanicoModel:PersonaModel
    {
        [Required]
        public String estado { get; set; }
        public MecanicoModel(string estado)
        {
            this.estado = estado;
        }
    }
}
