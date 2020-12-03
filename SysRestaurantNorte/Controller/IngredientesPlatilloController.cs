using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Data;
namespace Controller
{
    public class IngredientesPlatilloController
    {
        #region singleton
        private static readonly IngredientesPlatilloController _instance = new IngredientesPlatilloController();
        public static IngredientesPlatilloController instance
        {
            get { return _instance; }
        }
        #endregion singleton

        public List<IngredientePlatillo> list()
        {
            return IngredientesPlatilloData.Instancia.listar();
        }
    }
}
