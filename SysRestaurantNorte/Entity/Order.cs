using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Order
    {
        public int id {set;get;}
        public int idMesa { set;get;}
        public int idCliente {set;get;}

        public List<Platillo> platillo;

        public Order()
        {
            platillo = new List<Platillo>();
        }
    }
}
