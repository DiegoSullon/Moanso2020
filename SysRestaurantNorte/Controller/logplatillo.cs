using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entity;
using Data;


namespace Controller
{

    public class logplatillo
    {
        #region singleton
        //patron de Diseño Singleton
        private static readonly logplatillo _instancia = new logplatillo();
        public static logplatillo Instancia
        {
            get { return logplatillo._instancia; }
        }
        #endregion singleton

        public List<entplatillo> listarPlatillos()
        {
            return datPlatillo.instance.listar();
        }

        public void insertarPlatillo(entplatillo PLA)
        {
            try
            {
                datPlatillo.instance.insertar(PLA);
            }
            catch (Exception e)
            {
                throw e;

            }

        }
        public void editarPlatillo(entplatillo PLA)
        {
            try
            {
                datPlatillo.instance.insertar(PLA);
            }
            catch (Exception e)
            {
                throw e;

            }

        }
        public void eliminarPlatillo(string id)
        {
            try
            {
                datPlatillo.instance.eliminar(id);
            }
            catch (Exception e)
            {
                throw e;

            }

        }
    }
}
