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
    public class OrderData
    {
        private static readonly OrderData _instance = new OrderData();

        public static OrderData instance
        {
            get { return _instance; }
        }
        //List
        public List<Order> list()
        {
            SqlCommand cmd = null;
            SqlCommand cmd2 = null;
            List<Order> list = new List<Order>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cn.Open();
                cmd = new SqlCommand("spMostrarPedidos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Order Ord = new Order();
                    Ord.id = Convert.ToInt32(dr["id"]);
                    Ord.idCliente = Convert.ToInt32(dr["idCliente"]);
                    Ord.idMesa = Convert.ToInt32(dr["idMesa"]);

                    cmd2 = new SqlCommand("spMostrarDetallePlatillos", cn);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@id ", Ord.id);
                    SqlDataReader dr2 = cmd.ExecuteReader();
                    while (dr2.Read())
                    {
                        Platillo plat = new Platillo();
                        plat.id = Convert.ToInt32(dr["idPlatillo"]);
                        plat.name = dr["nombrePlatillo"].ToString();
                        plat.description = dr["descripcion"].ToString();
                        plat.state = Convert.ToBoolean(dr["estPlatillo"]);
                        Ord.platillo.Add(plat);
                    }

                    list.Add(Ord);
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Error list order data");
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return list;

        }
        //Insert

        public Boolean insert(Order Ord)
        {
            SqlCommand cmd = null;
            Boolean inserted = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cn.Open();
                cmd = new SqlCommand("spInsertarPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idMesa ", Ord.idMesa);
                cmd.Parameters.AddWithValue("@idCliente ", Ord.idCliente);
                int i = cmd.ExecuteNonQuery();
                if (i <= 0)
                {
                    return false;
                }
                cmd = new SqlCommand("spInsertaDetalle", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                for (int j =0;i< Ord.platillo.Count;j++)
                {
                    
                    cmd.Parameters.AddWithValue("@idPedido ", Ord.id);
                    cmd.Parameters.AddWithValue("@idPlatillo", Ord.platillo[j].id);
                    int h = cmd.ExecuteNonQuery();
                    if (h > 0)
                    {
                        inserted = true;
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserted;
        }

        //Delete
        public Boolean delete(int id)
        {
            SqlCommand cmd = null;
            Boolean deleted = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cn.Open();
                cmd = new SqlCommand("spEliminarPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPedido", id);
                int i = cmd.ExecuteNonQuery();
                if (i <= 0)
                {
                    return false;
                }
                cmd = new SqlCommand("spEliminaDetalle", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPedido", id);
                int h = cmd.ExecuteNonQuery();
                if (h > 0)
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
