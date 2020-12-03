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
    public class RolData
    {
        //patron de Diseño Singleton
        private static readonly RolData _instancia = new RolData();
        public static RolData Instancia
        {
            get { return _instancia; }
        }

        //Listado
        public List<Rol> listar()
        {
            SqlCommand cmd = null;
            List<Rol> lista = new List<Rol>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cn.Open();
                cmd = new SqlCommand("spListaRol", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Rol cli = new Rol();
                    cli.id = Convert.ToInt32(dr["RolID"]);
                    cli.name = dr["Descripcion"].ToString();
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
