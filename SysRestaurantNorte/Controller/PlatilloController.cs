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

        public List<Platillo> listarPlatillos()
        {
            return datPlatillo.instance.listar();
        }

        public void insertarPlatillo(Platillo PLA)
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
        public void editarPlatillo(Platillo PLA)
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
        public void eliminarPlatillo(int id)
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