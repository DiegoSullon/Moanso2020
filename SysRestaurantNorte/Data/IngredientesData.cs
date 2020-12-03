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
    class IngredientesData
    {
        //patron de Diseño Singleton
        private static readonly IngredientesData _instancia = new IngredientesData();
        public static IngredientesData Instancia
        {
            get { return _instancia; }
        }

        //Listado
        public List<Ingrediente> listar()
        {
            SqlCommand cmd = null;
            List<Ingrediente> lista = new List<Ingrediente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cn.Open();
                cmd = new SqlCommand("spListaIngrediente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Ingrediente ing = new Ingrediente();
                    ing.id = Convert.ToInt32(dr["CiudadID"]);
                    ing.name = dr["Nombre"].ToString();
                    lista.Add(ing);
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
    }
}
