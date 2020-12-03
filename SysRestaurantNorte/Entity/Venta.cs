using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Venta
    {
        public int id { get; set; }
        public int metodoPagoID { get; set; }
        public float total { get; set; }
        public int pedidoID { get; set; }

        public DateTime fecha { get; set; }
    }
}
