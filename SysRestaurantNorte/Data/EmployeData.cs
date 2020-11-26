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
    public class EmployeData
    {
        //patron de Diseño Singleton
        private static readonly EmployeData _instancia = new EmployeData();
        public static EmployeData Instancia
        {
            get { return _instancia; }
        }

        //Listado
        public List<Employe> listar()
        {
            SqlCommand cmd = null;
            List<Employe> lista = new List<Employe>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spMostrarEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Employe cli = new Employe();
                    cli.id = Convert.ToInt32(dr["id"]);
                    cli.dni = dr["dniCliente"].ToString();
                    cli.name = dr["nombre"].ToString();
                    cli.email = dr["correo"].ToString();
                    cli.idRol = Convert.ToInt32(dr["idRol"]);
                    lista.Add(cli);
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

        public Boolean insertar(Employe cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", cli.id);
                cmd.Parameters.AddWithValue("@dniCliente", cli.dni);
                cmd.Parameters.AddWithValue("@nombre", cli.name);
                cmd.Parameters.AddWithValue("@correo", cli.email);
                cmd.Parameters.AddWithValue("@idRol", cli.idRol);
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
        public Boolean editar(Employe cli)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", cli.id);
                cmd.Parameters.AddWithValue("@dniCliente", cli.dni);
                cmd.Parameters.AddWithValue("@nombre", cli.name);
                cmd.Parameters.AddWithValue("@correo", cli.email);
                cmd.Parameters.AddWithValue("@idRol", cli.idRol);
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
        public Boolean eliminar(int id)
        {
            SqlCommand cmd = null;
            Boolean elimina = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
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
