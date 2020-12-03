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
    public class TableData
    {
        private static readonly TableData _instance = new TableData();

        public static TableData instance
        {
            get{ return _instance; }
        }
        //List
        public List<Table> list()
        {
            SqlCommand cmd = null;
            List<Table> list = new List<Table>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaMesas", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Table Tab = new Table();
                    Tab.id = Convert.ToInt32(dr["idMesa"]);
                    Tab.seats = Convert.ToInt32(dr["cantAsientos"]);
                    Tab.description = dr["descripcion"].ToString();
                    Tab.state = Convert.ToBoolean(dr["estMesa"]);
                    list.Add(Tab);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en la conexion");
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return list;

        }
        //Insert

        public Boolean insert(Table tab)
        {
            SqlCommand cmd = null;
            Boolean inserted = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaMesa", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@cantAsientos ", tab.seats);
                cmd.Parameters.AddWithValue("@descripcion ", tab.description);
                cmd.Parameters.AddWithValue("@estMesa ", tab.state);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserted = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserted;
        }

        //Edit
        public Boolean edit(Table tab)
        {
            SqlCommand cmd = null;
            Boolean edited = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaMesa", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idMesa ", tab.id);
                cmd.Parameters.AddWithValue("@cantAsientos  ", tab.seats);
                cmd.Parameters.AddWithValue("@descripcion ", tab.description);
                cmd.Parameters.AddWithValue("@estMesa ", tab.state);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edited = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edited;
        }


        //Delete
        public Boolean delete(int id)
        {
            SqlCommand cmd = null;
            Boolean deleted = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminaMesa", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idMesa", id);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    deleted = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return deleted;
        }
    }
}
