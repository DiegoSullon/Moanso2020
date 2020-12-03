using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Venta
    {
        public int id { set; get; }
        public int metodoPagoID { set; get;}
        public float total { set; get;}
        public int pedidoID {set; get;}
    }
}
