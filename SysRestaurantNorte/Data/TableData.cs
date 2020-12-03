using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entity;
using System.Windows.Forms;

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
                cmd = new SqlCommand("spListaMesa", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Table Tab = new Table();
                    Tab.id = Convert.ToInt32(dr["MesaID"]);
                    Tab.description = dr["Descripcion"].ToString();
                    Tab.seats = Convert.ToInt32(dr["CantidadAsientos"]);
                    Tab.state = Convert.ToBoolean(dr["Estado"]);
                    list.Add(Tab);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
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

                cmd.Parameters.AddWithValue("@CantidadAsientos ", tab.seats);
                cmd.Parameters.AddWithValue("@Descripcion ", tab.description);
                cmd.Parameters.AddWithValue("@Estado ", tab.state);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserted = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
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
                cmd.Parameters.AddWithValue("@MesaID ", tab.id);
                cmd.Parameters.AddWithValue("@CantidadAsientos ", tab.seats);
                cmd.Parameters.AddWithValue("@Descripcion ", tab.description);
                cmd.Parameters.AddWithValue("@Estado ", tab.state);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edited = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
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
                cmd.Parameters.AddWithValue("@MesaID ", id);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    deleted = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return deleted;
        }
    }
}
