using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;//LIBRERIA PARA MOVER LA VENTANA
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using System.IO;
using Entity;
using Controller;

namespace GUI
{
    public partial class login : Form
    {
        private bool loged = false;
        public login()
        {
            InitializeComponent();
        }

        // IMPORTA DLL PARA EL MOVIMIENTO DE LA VENTANA
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        // TERMINA DE IMPORTA DLL PARA EL MOVIMIENTO DE LA VENTANA

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "USUARIO")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "USUARIO";
                txtuser.ForeColor = Color.Silver;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "CONTRASEÑA")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "CONTRASEÑA";
                txtpass.ForeColor = Color.Silver;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            MenuVertical mainMenu = new MenuVertical();
            mainMenu.Show();
            mainMenu.FormClosed += Logout;
            this.Hide();
            /*
            List<Employe> employes = EmployeController.Instancia.listar();
            for(int i=0;i< employes.Count; i++)
            {
                //MessageBox.Show(employes[i].name);
                //MessageBox.Show(employes[i].dni);
                if (txtuser.Text == employes[i].name && txtpass.Text== employes[i].dni)
                {
                        MenuVertical mainMenu = new MenuVertical();
                        mainMenu.Show();
                        mainMenu.FormClosed += Logout;
                        this.Hide();
                }
            }
            if (!loged)
            {
                msgError("Usuario o contraseña incorrecta.");
            }
            */

        }
        private async Task prueba()
        {
            MessageBox.Show("Azure Blob storage v12 - .NET quickstart sample\n");
            // Retrieve the connection string for use with the application. The storage
            // connection string is stored in an environment variable on the machine
            // running the application called AZURE_STORAGE_CONNECTION_STRING. If the
            // environment variable is created after the application is launched in a
            // console or with Visual Studio, the shell or application needs to be closed
            // and reloaded to take the environment variable into account.
            string connectionString = Environment.GetEnvironmentVariable("AZURE_STORAGE_CONNECTION_STRING");


            // Create a BlobServiceClient object which will be used to create a container client
            BlobServiceClient blobServiceClient = new BlobServiceClient("DefaultEndpointsProtocol=https;AccountName=restaurantnorteblob;AccountKey=G/W1+gDwqqPpM2Xo5m+UfKbdiC9/qFegrVqR7pvHmIHbQL8Q3uQqSTzrZgqacdee3rAfqZokV3WYtx3es0hY2g==;EndpointSuffix=core.windows.net");

            //Create a unique name for the container
            string containerName = "quickstartblobs";

            // Create the container and return a container client object
            //BlobContainerClient containerClient = await blobServiceClient.CreateBlobContainerAsync(containerName);
            BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(containerName);
            //MessageBox.Show("container: " + containerClient.Uri);
            containerClient.CreateIfNotExists();

            // Create a local file in the ./data/ directory for uploading and downloading

            string localFilePath = string.Empty;
            string fileName = string.Empty;

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "PDF files (*.pdf)|*.pdf;";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                localFilePath = openFile.FileName;
                fileName = openFile.SafeFileName;
            }
            MessageBox.Show(localFilePath);

            // Write text to the file
            //File.WriteAllText(localFilePath, "Hello, World!");

            BlobClient blobClient = containerClient.GetBlobClient(fileName);

            Console.WriteLine("Uploading to Blob storage as blob:\n\t {0}\n", blobClient.Uri);

            // Open the file and upload its data
            using FileStream uploadFileStream = File.OpenRead(localFilePath);
            await blobClient.UploadAsync(uploadFileStream, true);
            uploadFileStream.Close();

            MessageBox.Show("Listing blobs...");

            // List all blobs in the container
            await foreach (BlobItem blobItem in containerClient.GetBlobsAsync())
            {
                MessageBox.Show("\t" + blobItem.Name);
            }

            SaveFileDialog saveFile = new SaveFileDialog();
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                localFilePath = saveFile.FileName;
                //fileName = saveFile.get
            }
            MessageBox.Show(localFilePath);
            // Get a reference to a blob
            
            // Download the blob to a local file
            // Append the string "DOWNLOADED" before the .txt extension 
            // so you can compare the files in the data directory
            //string downloadFilePath = localFilePath.Replace(".txt", "DOWNLOADED.txt");
            string downloadFilePath = localFilePath;
            downloadFilePath = downloadFilePath.Replace(".pdf","");
            downloadFilePath = downloadFilePath + ".pdf";

            MessageBox.Show("\nDownloading blob to\n\t{0}\n"+ downloadFilePath);

            // Download the blob's contents and save it to a file
            BlobDownloadInfo download = await blobClient.DownloadAsync();
            MessageBox.Show("\nGaaaa\n\t{0}\n" + download.ToString());
            using (FileStream downloadFileStream = File.OpenWrite(downloadFilePath))
            {
                await download.Content.CopyToAsync(downloadFileStream);
                downloadFileStream.Close();
            }

            //await containerClient.DeleteAsync();
        }

        private void msgError(string msg)
        {
            lblErrorMessagge.Text = "       " + msg;
            lblErrorMessagge.Visible = true;

        }
    
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtpass.Text = "CONTRASEÑA";
            txtpass.UseSystemPasswordChar = false;
            txtuser.Text = "USUARIO";
            lblErrorMessagge.Visible = false;
            this.Show();
        }
    }
}
