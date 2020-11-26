using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Data;

namespace Controller
{

    public class EmployeController
    {
        #region singleton
        private static readonly EmployeController _instancia = new EmployeController();
        public static EmployeController Instancia
        {
            get { return EmployeController._instancia; }
        }
        #endregion singleton

        public List<Employe> listarSectors()
        {
            return EmployeData.Instancia.listar();
        }

        public void insertarSector(Employe SEC)
        {
            try
            {
                EmployeData.Instancia.insertar(SEC);
            }
            catch (Exception e)
            {
                throw e;

            }

        }
        public void editarSector(Employe SEC)
        {
            try
            {
                EmployeData.Instancia.editar(SEC);
            }
            catch (Exception e)
            {
                throw e;

            }

        }
        public void eliminarSector(int id)
        {
            try
            {
                EmployeData.Instancia.eliminar(id);
            }
            catch (Exception e)
            {
                throw e;

            }

        }
    }
}
