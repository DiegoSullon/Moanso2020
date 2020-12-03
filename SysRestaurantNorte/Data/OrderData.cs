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
                cmd = new SqlCommand("spListarPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Order Ord = new Order();
                    Ord.id = Convert.ToInt32(dr["PedidoID"]);
                    Ord.idCliente = Convert.ToInt32(dr["ClienteID"]);
                    Ord.idMesa = Convert.ToInt32(dr["mesID"]);

                    cmd2 = new SqlCommand("spListaDetallepedido", cn);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@PedidoID ", Ord.id);
                    SqlDataReader dr2 = cmd.ExecuteReader();
                    while (dr2.Read())
                    {
                        Platillo plat = new Platillo();
                        plat.id = Convert.ToInt32(dr2["PlatilloID"]);
                        plat.name = dr2["NombrePlatillo"].ToString();
                        plat.tipoPlatilloId = Convert.ToInt32(dr2["TipoPlatilloID"]);
                        plat.tPreparacion = dr2["TiempoPreparacion"].ToString();
                        plat.precio = Convert.ToSingle(dr2["Precio"]);
                        Ord.platillo.Add(plat);
                    }

                    list.Add(Ord);
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

        public Boolean insert(Order Ord)
        {
            SqlCommand cmd = null;
            Boolean inserted = false;
            int id;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cn.Open();
                cmd = new SqlCommand("spInsertaPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteID", Ord.idCliente);
                cmd.Parameters.AddWithValue("@MesaID", Ord.idMesa);
                int i = cmd.ExecuteNonQuery();
                if (i <= 0)
                {
                    return false;
                }

                cmd = new SqlCommand("spMayorIndice", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Table", "Pedido");
                cmd.Parameters.AddWithValue("@Column", "PedidoID");
                SqlDataReader dr = cmd.ExecuteReader();
                id = dr.GetInt32(0);

                cmd = new SqlCommand("spInsertaDetallepedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                List<Platillo> carry = new List<Platillo>();
                int count = -1;
                for (int j = 0; i < Ord.platillo.Count; j++)
                {
                    if (!carry.Contains(Ord.platillo[j]))
                    {
                        count++;
                        carry.Add(Ord.platillo[j]);
                        carry[count].count = 1;
                    }
                    else
                    {
                        carry[count].count++;
                    }
                    
                }
                for (int j =0;i< carry.Count;j++)
                {
                    
                    cmd.Parameters.AddWithValue("@PedidoID", id);
                    cmd.Parameters.AddWithValue("@Cantidad", carry[j].count);
                    cmd.Parameters.AddWithValue("@PlatilloID", carry[j].id);
                    int h = cmd.ExecuteNonQuery();
                    if (h > 0)
                    {
                        inserted = true;
                    }
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

        //Delete
        public Boolean delete(int id)
        {
            SqlCommand cmd = null;
            Boolean deleted = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cn.Open();
                cmd = new SqlCommand("spEliminaVPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PedidoID", id);
                int i = cmd.ExecuteNonQuery();
                if (i <= 0)
                {
                    return false;
                }
                cmd = new SqlCommand("spEliminaDetallepedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PedidoID", id);
                int h = cmd.ExecuteNonQuery();
                if (h > 0)
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
