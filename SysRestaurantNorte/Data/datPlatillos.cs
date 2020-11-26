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
        public List<entplatillo> listar()
        {
            SqlCommand cmd = null;
            List<entplatillo> lista = new List<entplatillo>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaPlatillos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entplatillo PLA = new entplatillo();
                    PLA.idPlatillo = Convert.ToInt32(dr["idPlatillo"]);
                    PLA.nombrePlatillo = dr["nombrePlatillo"].ToString();
                    PLA.descripcion = dr["descripcion"].ToString();
                    PLA.estPlatillo = Convert.ToBoolean(dr["estPlatillo"]);
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

        public Boolean insertar(entplatillo PLAT)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaPlatillo", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombrePlatillo", PLAT.nombrePlatillo);
                cmd.Parameters.AddWithValue("@descripcion", PLAT.descripcion);
                cmd.Parameters.AddWithValue("@estPlatillo", PLAT.estPlatillo);
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
        public Boolean editar(entplatillo PLAT)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaPlatillo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombrePlatillo", PLAT.nombrePlatillo);
                cmd.Parameters.AddWithValue("@descripcion", PLAT.descripcion);
                cmd.Parameters.AddWithValue("@estPlatillo", PLAT.estPlatillo);
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
