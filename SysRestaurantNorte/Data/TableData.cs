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
    class TableData
    {
        private static readonly TableData _instance = new TableData();

        public static TableData instance()
        {
            return _instance;
        }
        //List
        public List<Table> list()
        {
            SqlCommand cmd = null;
            List<Table> lista = new List<Table>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Table SEC = new Table();
                    SEC.id = dr["id"].ToString();
                    SEC.name = dr["name"].ToString();
                    SEC.price = Convert.ToSingle(dr["price"]);
                    lista.Add(SEC);
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
    }
}
