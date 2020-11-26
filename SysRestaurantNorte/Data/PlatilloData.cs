using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entity;

namespace Data

{
    public class datPlatillo
    {
        //patron de Diseño Singleton
        private static readonly datPlatillo _instance = new datPlatillo();
        public static datPlatillo instance
        {
            get { return _instance; }
        }

        //Listado
        public List<Platillo> listar()
        {
            SqlCommand cmd = null;
            List<Platillo> lista = new List<Platillo>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaPlatillos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Platillo PLA = new Platillo();
                    PLA.id = Convert.ToInt32(dr["idPlatillo"]);
                    PLA.name = dr["nombrePlatillo"].ToString();
                    PLA.description = dr["descripcion"].ToString();
                    PLA.state = Convert.ToBoolean(dr["estPlatillo"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en la conexion");
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;

        }

        //Insertar

        public Boolean insertar(Platillo PLAT)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaPlatillo", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombrePlatillo", PLAT.name);
                cmd.Parameters.AddWithValue("@descripcion", PLAT.description);
                cmd.Parameters.AddWithValue("@estPlatillo", PLAT.state);
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
        public Boolean editar(Platillo PLAT)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaPlatillo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombrePlatillo", PLAT.name);
                cmd.Parameters.AddWithValue("@descripcion", PLAT.description);
                cmd.Parameters.AddWithValue("@estPlatillo", PLAT.state);
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
                cmd = new SqlCommand("spDeshabilitaPlatillo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPlatillo", id);
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