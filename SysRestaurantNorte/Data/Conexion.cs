using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Azure.Storage.Blobs;

namespace Data
{
    public class Conexion
    {
        //patron de Diseño Singleton
        private static readonly Conexion _instancia = new Conexion();
        public static readonly SqlConnection connection = _instancia.Conectar();
        public static Conexion Instancia
        {
            get { return Conexion._instancia; }
        }
        public static SqlConnection Connection
        {
            get { return connection; }
        }

        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Server=tcp:restaurantnorte.database.windows.net,1433;Initial Catalog=RestaurantNorte;Persist Security Info=False;User ID=sysrestaurantnorte;Password=Moanso2020;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            return cn;
        }
        public BlobServiceClient connectStorage()
        {
            string connectionString = Environment.GetEnvironmentVariable("AZURE_STORAGE_CONNECTION_STRING");


            // Create a BlobServiceClient object which will be used to create a container client
            BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);

            return blobServiceClient;
        }
    }
}
