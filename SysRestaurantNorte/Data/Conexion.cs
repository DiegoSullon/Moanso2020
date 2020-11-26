using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Data
{
    public class Conexion
    {
        //patron de Diseño Singleton
        private static readonly Conexion _instancia = new Conexion();
        public static Conexion Instancia
        {
            get { return Conexion._instancia; }
        }
    
           
        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=DESKTOP-FV5LUU9\\SQLEXPRESS; Initial Catalog=SectoresTeatro; Integrated Security=true";

            return cn;
        }
    }
}
