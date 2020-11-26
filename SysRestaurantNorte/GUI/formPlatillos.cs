using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class formPlatillos : Form
    {
        public formPlatillos()
        {
            InitializeComponent();
            rbID.Checked = true;
            groupBox.Enabled = false;
        }
        private void LimpiarCampos()
        {
            lbID.Text = "";
            txtDescripcion.Text = " ";
            cbEstado.Checked = false;
            txtNombre.Text = " ";
            txtPrecio.Text = " ";
        }


        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
            btnGuardar.Visible = true;
            groupBox.Enabled = true;
            LimpiarCampos();
        }
    }
}
