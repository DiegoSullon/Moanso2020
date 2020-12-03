using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Data;
namespace Controller
{
    public class IngredienteController
    {
        #region singleton
        private static readonly IngredienteController _instance = new IngredienteController();
        public static IngredienteController instance
        {
            get { return _instance; }
        }
        #endregion singleton

        public List<Ingrediente> list()
        {
            return IngredientesData.Instancia.listar();
        }
    }
}
