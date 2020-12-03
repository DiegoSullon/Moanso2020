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

        public void insertar(Employe SEC, OpenFileDialog file)
        {
            try
            {
                if (file != null)
                {
                    if (file.FileName.Equals(""))
                    {
                        MessageBox.Show("vacio");
                    }
                    else
                    {
                        EmployeData.Instancia.uploadCV(file);
                        MessageBox.Show(file.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Cv no cargado");
                }
                EmployeData.Instancia.insertar(SEC);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
                throw e;

            }

        }
        public bool editar(Employe SEC, OpenFileDialog file)
        {
            try
            {
                if (file != null)
                {
                    if (file.FileName.Equals(""))
                    {
                        MessageBox.Show("vacio");
                    }
                    else
                    {
                        MessageBox.Show("vacio: " + file.ToString());
                        EmployeData.Instancia.uploadCV(file);
                    }
                }
                else
                {
                    MessageBox.Show("Cv no cargado");
                }
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
        public void downloadCv(string downloadFilePath, string fileName)
        {
            try
            {
                EmployeData.Instancia.downloadCV(downloadFilePath, fileName);
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
