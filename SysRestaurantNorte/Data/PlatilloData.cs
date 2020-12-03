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
            SqlCommand cmd2 = null;
            List<Platillo> lista = new List<Platillo>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cn.Open();
                cmd = new SqlCommand("spListaPlatillo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                SqlDataReader dr2;
                while (dr.Read())
                {
                    Platillo PLA = new Platillo();
                    PLA.id = Convert.ToInt32(dr["PlatilloID"]);
                    PLA.name = dr["NombrePlatillo"].ToString();
                    PLA.tipoPlatilloId = Convert.ToInt32(dr["TipoPlatilloID"]);
                    PLA.tPreparacion = dr["TiempoPreparacion"].ToString();
                    PLA.precio = Convert.ToSingle(dr["Precio"]);
                    lista.Add(PLA);
                    //MessageBox.Show(PLA.name);
                }
                dr.Close();
                for (int i=0;i<lista.Count;i++)
                {
                    cmd = new SqlCommand("spListaIngredienteplatillo", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PlatilloID ", lista[i].id);
                    dr2 = cmd.ExecuteReader();
                    while (dr2.Read())
                    {
                        Ingrediente ing = new Ingrediente();
                        ing.id = Convert.ToInt32(dr2["IngredientesID"]);
                        ing.name = dr2["NombreIngrediente"].ToString();
                        lista[i].ingredientes.Add(ing);
                        //MessageBox.Show(lista[i].name);
                    }
                    dr2.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
                throw e;
            }
            finally { cmd.Connection.Close(); }
            
            return lista;

        }

        //Insertar

        public Boolean insertar(Platillo PLAT)
        {
            SqlCommand cmd = null;
            Boolean inserted = false;
            int id=0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaPlatillo", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@NombrePlatillo", PLAT.name);
                cmd.Parameters.AddWithValue("@TipoPlatilloID", PLAT.tipoPlatilloId);
                cmd.Parameters.AddWithValue("@TiempoPreparacion", PLAT.tPreparacion);
                cmd.Parameters.AddWithValue("@Precio", PLAT.precio);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i <= 0)
                {
                    return false;
                }

                cmd = new SqlCommand("spMayorIndice", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Table", "Platillo");
                cmd.Parameters.AddWithValue("@Column", "PlatilloID");
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read()) { id = dr.GetInt32(0); }
                

                cmd = new SqlCommand("spInsertaIngredienteplatillo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                for (int j = 0; i < PLAT.ingredientes.Count; j++)
                {

                    cmd.Parameters.AddWithValue("@PlatilloID ", id);
                    cmd.Parameters.AddWithValue("@IngredientesID", PLAT.ingredientes[j].id);
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
                cmd.Parameters.AddWithValue("@PlatilloID", PLAT.id);
                cmd.Parameters.AddWithValue("@NombrePlatillo", PLAT.name);
                cmd.Parameters.AddWithValue("@TipoPlatilloID", PLAT.tipoPlatilloId);
                cmd.Parameters.AddWithValue("@TiempoPreparacion", PLAT.tPreparacion);
                cmd.Parameters.AddWithValue("@Precio", PLAT.precio);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
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
                cmd = new SqlCommand("spEliminaPlatillo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PlatilloID", id);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    return false;
                }
                cmd = new SqlCommand("spEliminaIngredientePlatillo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PlatilloID", id);
                int h = cmd.ExecuteNonQuery();
                if (h > 0)
                {
                    elimina = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return elimina;
        }

    }
}