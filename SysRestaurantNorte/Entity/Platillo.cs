using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{

    public class Platillo
    {
        public int id { get; set; }
        public string name { get; set; }
        public int tipoPlatilloId { get; set; }
        public string tPreparacion { get; set; }
        public float precio { get; set; }

        public List<Ingrediente> ingredientes { get; set; }
        //variable auxiliar, no ingresar a db
        public int count { get; set; }
    }
}