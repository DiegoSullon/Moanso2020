using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Client
    {
        public int id { get; set; }
        public int ciudadId { get; set; }
        public int tipoClienteId { get; set; }
        public string  dni { get; set; }
        public string name { get; set; }
        public string apellidos { get; set; }
        public string email { get; set; }
        public string ruc { get; set; }
        public DateTime fNacmiento { get; set; }
      
    }
}
