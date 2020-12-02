using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Entity;

namespace Data

{
    public class ClientData
    {
        //patron de Diseño Singleton
        private static readonly ClientData _instancia = new ClientData();
        public static ClientData Instancia
        {
            get { return _instancia; }
        }

        //Listado
        public List<Client> listar()
        {
            SqlCommand cmd = null;
            List<Client> lista = new List<Client>();
            try {
                SqlConnection cn = Conexion.Instancia.Conectar();
                MessageBox.Show("1");
                cn.Open();
                MessageBox.Show("2");
                cmd = new SqlCommand("spListarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Client cli = new Client();
                    cli.id = Convert.ToInt32(dr["ClienteID"]);
                    cli.dni = dr["DNI"].ToString();
                    cli.name = dr["Nombre"].ToString();
                    cli.email = dr["Correo"].ToString();
                    lista.Add(cli);
                }
            } 
            catch ( Exception e) {
                MessageBox.Show("Error: "+e);
                throw e;
            }
            finally { 
                cmd.Connection.Close(); 
            }
            return lista;

        }
     
     //Insertar

        public Boolean insertar(Client cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dniCliente", cli.dni);
                cmd.Parameters.AddWithValue("@nombre", cli.name);
                cmd.Parameters.AddWithValue("@correo", cli.email);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

        //Editar
        public Boolean editar(Client cli)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dniCliente", cli.dni);
                cmd.Parameters.AddWithValue("@nombre", cli.name);
                cmd.Parameters.AddWithValue("@correo", cli.email);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }


        //Eliminar
        public Boolean eliminar(string dni)
        {
            SqlCommand cmd = null;
            Boolean elimina = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dniCliente", dni);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    elimina = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return elimina;
        }
        
    }
}
