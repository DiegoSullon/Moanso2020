using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data
{
    public class CiudadData
    {
        //patron de Diseño Singleton
        private static readonly CiudadData _instancia = new CiudadData();
        public static CiudadData Instancia
        {
            get { return _instancia; }
        }

        //Listado
        public List<Ciudad> listar()
        {
            SqlCommand cmd = null;
            List<Ciudad> lista = new List<Ciudad>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cn.Open();
                cmd = new SqlCommand("spListaCiudad", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Ciudad cli = new Ciudad();
                    cli.id = Convert.ToInt32(dr["CiudadID"]);
                    cli.name = dr["Nombre"].ToString();
                    lista.Add(cli);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;

        }
    }
}
