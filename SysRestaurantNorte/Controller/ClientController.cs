using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Data;

namespace Controller
{
    
    public class ClientController
    {
        #region singleton
        private static readonly ClientController _instancia = new ClientController();
        public static ClientController Instancia
        {
            get { return ClientController._instancia; }
        }
        #endregion singleton

        public List<Client> listarSectors()
        {
            return ClientData.Instancia.listar();
        }
        
        public void insertarSector(Client SEC)
        {
            try 
            {
                ClientData.Instancia.insertar(SEC);
            }
        catch(Exception e )
            { throw e;  
            
            }

        }
        public void editarSector(Client SEC)
        {
            try
            {
                ClientData.Instancia.editar(SEC);
            }
            catch (Exception e)
            {
                throw e;

            }

        }
        public void eliminarSector(string dni)
        {
            try
            {
                ClientData.Instancia.eliminar(dni);
            }
            catch (Exception e)
            {
                throw e;

            }

        }
    }
}
