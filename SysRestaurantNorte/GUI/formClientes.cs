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
    public partial class formClientes : Form
    {
        public formClientes()
        {
            InitializeComponent();
            rbID.Checked = true;
            groupBox.Enabled = false;
        }
        private void LimpiarCampos()
        {
            lbID.Text = "";
            txtCorreo.Text = " ";
            txtNombre.Text = " ";
            txtDni.Text = " ";
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
            btnGuardar.Visible = true;
            groupBox.Enabled = true;
            LimpiarCampos();
        }
    }
}
