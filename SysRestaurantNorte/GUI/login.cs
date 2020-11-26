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
namespace GUI
{
    public partial class login : Form
    {
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
            if (txtuser.Text != "USUARIO" && txtuser.TextLength > 2)
            {
                if (txtpass.Text != "CONTRASEÑA")
                {/*
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtuser.Text, txtpass.Text);
                    if (validLogin == true)
                    {*/
                        mainMenu mainMenu = new mainMenu();
                        MessageBox.Show(" Bienvenido ");
                        mainMenu.Show();
                        mainMenu.FormClosed += Logout;
                        this.Hide();/*
                    }
                    else
                    {
                        msgError("Incorrect username or password entered. \n   Please try again.");
                        txtpass.Text = "Password";
                        txtpass.UseSystemPasswordChar = false;
                        txtuser.Focus();
                    }*/
                }
                else msgError("Por favor Ingresar la Contraseña.");
            }
            else msgError("Por favor Ingresar el Usuario.");
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
