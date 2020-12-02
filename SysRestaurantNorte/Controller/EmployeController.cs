using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Entity;
using System.IO;
using Data;
using System.Windows.Forms;

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

        public List<Employe> listar()
        {
            return EmployeData.Instancia.listar();
        }

        public async Task insertarAsync(Employe SEC, OpenFileDialog file)
        {
            try
            {
                await EmployeData.Instancia.uploadCV(file);
                EmployeData.Instancia.insertar(SEC);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
                throw e;

            }

        }
        public bool editar(Employe SEC)
        {
            try
            {
                EmployeData.Instancia.editar(SEC);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
                throw e;

            }
            return true;

        }
        public void eliminar(int id)
        {
            try
            {
                EmployeData.Instancia.eliminar(id);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
                throw e;

            }

        }
        public async Task downloadCvAsync(string downloadFilePath, string fileName)
        {
            try
            {
               await EmployeData.Instancia.downloadCV(downloadFilePath, fileName);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
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
