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
    public class VentaData
    {
        //patron de Diseño Singleton
        private static readonly VentaData _instancia = new VentaData();
        public static VentaData Instancia
        {
            get { return _instancia; }
        }

        //Listado
        public List<Venta> listar()
        {
            SqlCommand cmd = null;
            List<Venta> lista = new List<Venta>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cn.Open();
                cmd = new SqlCommand("spListaVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Venta ven = new Venta();
                    ven.id = Convert.ToInt32(dr["VentaID"]);
                    ven.metodoPagoID = Convert.ToInt32(dr["MetodopagoID"]);
                    ven.total = Convert.ToSingle(dr["MontoTotal"]);
                    ven.pedidoID = Convert.ToInt32(dr["PedidoID"]);
                    ven.fecha = Convert.ToDateTime(dr["FechaVenta"]);
                    lista.Add(ven);
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

        //Insertar

        public Boolean insertar(Venta ven)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MetodopagoID", ven.metodoPagoID);
                cmd.Parameters.AddWithValue("@MontoTotal", ven.total);
                cmd.Parameters.AddWithValue("@PedidoID", ven.pedidoID);
                //cmd.Parameters.AddWithValue("@FechaVenta", ven.fecha);
                SqlParameter parameter = cmd.Parameters.Add("@FechaVenta",
                System.Data.SqlDbType.DateTime);

                // Set the value.
                parameter.Value = DateTime.Now;

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

        //Eliminar
        public Boolean eliminar(int id)
        {
            SqlCommand cmd = null;
            Boolean elimina = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminaVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VentaID", id); ;
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
