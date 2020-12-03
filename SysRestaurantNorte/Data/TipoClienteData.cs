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
    public class TipoClienteData
    {
        //patron de Diseño Singleton
        private static readonly TipoClienteData _instancia = new TipoClienteData();
        public static TipoClienteData Instancia
        {
            get { return _instancia; }
        }

        //Listado
        public List<TipoCliente> listar()
        {
            SqlCommand cmd = null;
            List<TipoCliente> lista = new List<TipoCliente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cn.Open();
                cmd = new SqlCommand("spListaTipoCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TipoCliente cli = new TipoCliente();
                    cli.id = Convert.ToInt32(dr["TipoclienteID"]);
                    cli.name = dr["TipoPersona"].ToString();
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
