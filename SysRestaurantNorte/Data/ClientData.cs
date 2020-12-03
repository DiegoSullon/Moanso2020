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
                    cli.ciudadId = Convert.ToInt32(dr["CiudadID"]);
                    cli.tipoClienteId = Convert.ToInt32(dr["TipoclienteID"]);
                    cli.dni = dr["DNI"].ToString();
                    cli.name = dr["Nombre"].ToString();
                    cli.apellidos = dr["Apellidos"].ToString();
                    cli.email = dr["Correo"].ToString();
                    cli.ruc = dr["RUC"].ToString();
                    cli.fNacmiento =Convert.ToDateTime(dr["FechaNacimiento"]);
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
                cmd = new SqlCommand("spInsertaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CiudadID", cli.ciudadId);
                cmd.Parameters.AddWithValue("@Nombre", cli.name);
                cmd.Parameters.AddWithValue("@TipoclienteID", cli.tipoClienteId);
                cmd.Parameters.AddWithValue("@Apellidos", cli.apellidos);
                cmd.Parameters.AddWithValue("@DNI", cli.dni);
                cmd.Parameters.AddWithValue("@RUC", cli.ruc);
                cmd.Parameters.AddWithValue("@Correo", cli.email);
                cmd.Parameters.AddWithValue("@FechaNacimiento", cli.fNacmiento);
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
                cmd = new SqlCommand("spEditaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteID", cli.id);
                cmd.Parameters.AddWithValue("@CiudadID", cli.ciudadId);
                cmd.Parameters.AddWithValue("@Nombre", cli.name);
                cmd.Parameters.AddWithValue("@TipoclienteID", cli.tipoClienteId);
                cmd.Parameters.AddWithValue("@Apellidos", cli.apellidos);
                cmd.Parameters.AddWithValue("@DNI", cli.dni);
                cmd.Parameters.AddWithValue("@RUC", cli.ruc);
                cmd.Parameters.AddWithValue("@Correo", cli.email);
                cmd.Parameters.AddWithValue("@FechaNacimiento", cli.fNacmiento);
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
        public Boolean eliminar(int id)
        {
            SqlCommand cmd = null;
            Boolean elimina = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteID", id);;
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
