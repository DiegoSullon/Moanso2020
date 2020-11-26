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
    public partial class MenuVertical : Form
    {
        public MenuVertical()
        {
            InitializeComponent();
            btnDash_Click(null, null);

        }
        // IMPORTA DLL PARA EL MOVIMIENTO DE LA VENTANA
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        // TERMINA DE IMPORTA DLL PARA EL MOVIMIENTO DE LA VENTANA

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AbrirFormHija (object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnMesas_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new formMesa());
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
           AbrirFormHija(new formDash());
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new formPedidos());
        }

        private void btnPlatillos_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new formPlatillos());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new formClientes());
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new formEmpleados());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new formVentas());
        }
    }
}
