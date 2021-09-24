using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carcenter.Models.ViewModels
{
    public class ProductoTiendaFactura
    {
        public int id { get; set; }
        public int productoTiendaId { get; set; }
        public ProductoModel idProducto { get; set; }
        public TiendaModel idTienda { get; set; }
        public FacturaModel idFactura { get; set; }
        public ClienteModel idCliente { get; set; }

        public MecanicoModel idMecanico { get; set; }

    }
}
