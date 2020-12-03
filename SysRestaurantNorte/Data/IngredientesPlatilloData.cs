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
    public class IngredientesPlatilloData
    {
        //patron de Diseño Singleton
        private static readonly IngredientesPlatilloData _instancia = new IngredientesPlatilloData();
        public static IngredientesPlatilloData Instancia
        {
            get { return _instancia; }
        }

        //Listado
        public List<IngredientePlatillo> listar()
        {
            SqlCommand cmd = null;
            List<IngredientePlatillo> lista = new List<IngredientePlatillo>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cn.Open();
                cmd = new SqlCommand("spListaIngredienteplatillo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    IngredientePlatillo ingre = new IngredientePlatillo();
                    ingre.id = Convert.ToInt32(dr["IngredienteplatilloID"]);
                    ingre.id = Convert.ToInt32(dr["PlatilloID"]);
                    ingre.id = Convert.ToInt32(dr["IngredientesID"]);
                    lista.Add(ingre);
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

        public Boolean insertar(IngredientePlatillo ingrepl)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaIngredienteplatillo", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", ingrepl.platilloID);
                cmd.Parameters.AddWithValue("@RolID", ingrepl.IngredientesID);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }
    }
}
