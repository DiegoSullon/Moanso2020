using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
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
        public bool editarSector(Employe SEC)
        {
            try
            {
                if (!isEmail(SEC.email))
                {
                    return false;
                }
                EmployeData.Instancia.editar(SEC);
            }
            catch (Exception e)
            {
                throw e;

            }
            return true;

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
        private Boolean isEmail(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
