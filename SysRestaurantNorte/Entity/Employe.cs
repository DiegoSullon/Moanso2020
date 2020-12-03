using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Employe
    {
        public int id { get; set; }
        public string dni { get; set; }
        public string name { get; set; }
        public string apellido { get; set; }
        public string cv { get; set; }
        public string telefono { get; set; }
        public DateTime fNacimiento { get; set; }
        public int idRol { get; set; }

    }
}
