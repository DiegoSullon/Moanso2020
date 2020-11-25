using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using CapaEntidad;

namespace CapaAccesoDatos
{
    public class datSector
    {
        //patron de Diseño Singleton
        private static readonly datSector _instancia = new datSector();
        public static datSector Instancia
        {
            get { return datSector._instancia; }
        }

        //Listado
        public List<entSector> listar()
        {
            SqlCommand cmd = null;
            List<entSector> lista = new List<entSector>();
            try {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListar",cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entSector SEC = new entSector();
                    SEC.id = dr["id"].ToString();
                    SEC.name = dr["name"].ToString();
                    SEC.price = Convert.ToSingle(dr["price"]);
                    lista.Add(SEC);
                }
            } 
            catch ( Exception e) {
                Console.WriteLine("Error en la conexion");
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;

        }
     
     //Insertar

        public Boolean insertar(entSector SEC)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("insertar", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", SEC.id);
                cmd.Parameters.AddWithValue("@name", SEC.name);
                cmd.Parameters.AddWithValue("@price", SEC.price);
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
        public Boolean editar(entSector SEC)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", SEC.id);
                cmd.Parameters.AddWithValue("@name", SEC.name);
                cmd.Parameters.AddWithValue("@price", SEC.price);
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
        public Boolean eliminar(string id)
        {
            SqlCommand cmd = null;
            Boolean elimina = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
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
