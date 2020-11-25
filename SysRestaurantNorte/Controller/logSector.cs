using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogicaNegocio
{
    
    public class logSector
    {
        #region singleton
        //patron de Diseño Singleton
        private static readonly logSector _instancia = new logSector();
        public static logSector Instancia
        {
            get { return logSector._instancia; }
        }
        #endregion singleton

        public List<entSector> listarSectors()
        {
            return datSector.Instancia.listar();
        }
        
        public void insertarSector(entSector SEC)
        {
            try 
            {
                datSector.Instancia.insertar(SEC);
            }
        catch(Exception e )
            { throw e;  
            
            }

        }
        public void editarSector(entSector SEC)
        {
            try
            {
                datSector.Instancia.editar(SEC);
            }
            catch (Exception e)
            {
                throw e;

            }

        }
        public void eliminarSector(string id)
        {
            try
            {
                datSector.Instancia.eliminar(id);
            }
            catch (Exception e)
            {
                throw e;

            }

        }
    }
}
