using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entity;
using Azure.Storage.Blobs;
using System.IO;
using System.Windows.Forms;
using Azure.Storage.Blobs.Models;

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
                    cli.id = Convert.ToInt32(dr["EmpleadoID"]);
                    cli.name = dr["Nombre"].ToString();
                    cli.idRol = Convert.ToInt32(dr["RolID"]);
                    cli.apellido = dr["Apellido"].ToString();
                    cli.dni = dr["DNI"].ToString();
                    cli.cv = dr["CV"].ToString();
                    cli.telefono = dr["Telefono"].ToString();
                    cli.fNacimiento = Convert.ToDateTime(dr["FechaNacimiento"]);
                    lista.Add(cli);
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

        public Boolean insertar(Employe cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", cli.name);
                cmd.Parameters.AddWithValue("@RolID", cli.idRol);
                cmd.Parameters.AddWithValue("@Apellido", cli.apellido);
                cmd.Parameters.AddWithValue("@DNI", cli.dni);
                cmd.Parameters.AddWithValue("@CV", cli.cv);
                cmd.Parameters.AddWithValue("@Telefono", cli.telefono);
                cmd.Parameters.AddWithValue("@FechaNacimiento", cli.fNacimiento);
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
                cmd.Parameters.AddWithValue("@EmpleadoID", cli.id);
                cmd.Parameters.AddWithValue("@Nombre", cli.name);
                cmd.Parameters.AddWithValue("@RolID", cli.idRol);
                cmd.Parameters.AddWithValue("@Apellido", cli.apellido);
                cmd.Parameters.AddWithValue("@DNI", cli.dni);
                cmd.Parameters.AddWithValue("@CV", cli.cv);
                cmd.Parameters.AddWithValue("@Telefono", cli.telefono);
                cmd.Parameters.AddWithValue("@FechaNacimiento", cli.fNacimiento);
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
                cmd = new SqlCommand("spEliminarEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmpleadoID",id);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
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

        //upload cv
        public async Task uploadCV(OpenFileDialog file)
        {
            // Create a BlobServiceClient object which will be used to create a container client
            BlobServiceClient blobServiceClient = Conexion.Instancia.connectStorage();

            //Create a unique name for the container
            string containerName = "employecv";
            // Create the container and return a container client object
            BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(containerName);
            containerClient.CreateIfNotExists();

            BlobClient blobClient = containerClient.GetBlobClient(file.SafeFileName);
            // Open the file and upload its data
            using FileStream uploadFileStream = File.OpenRead(file.FileName);
            await blobClient.UploadAsync(uploadFileStream, true);
            uploadFileStream.Close();
        }
        //download cv
        public async Task downloadCV(string downloadFilePath, string fileName)
        {
            // Create a BlobServiceClient object which will be used to create a container client
            BlobServiceClient blobServiceClient = Conexion.Instancia.connectStorage();

            //Create a unique name for the container
            string containerName = "employecv";
            // Create the container and return a container client object
            BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(containerName);
            containerClient.CreateIfNotExists();

            BlobClient blobClient = containerClient.GetBlobClient(fileName);

            // Download the blob's contents and save it to a file
            BlobDownloadInfo download = await blobClient.DownloadAsync();
            //MessageBox.Show("\nGaaaa\n\t{0}\n" + download.ToString());
            using (FileStream downloadFileStream = File.OpenWrite(downloadFilePath))
            {
                await download.Content.CopyToAsync(downloadFileStream);
                MessageBox.Show("Descargado");
                downloadFileStream.Close();
            }
        }

    }
}
