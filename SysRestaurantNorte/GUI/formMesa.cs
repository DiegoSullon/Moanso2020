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
    public partial class formMesa : Form
    {
        public formMesa()
        {
            InitializeComponent();
            rbID.Checked = true;
            groupBox.Enabled = false;
        }
        private void LimpiarCampos()
        {
            lbID.Text = "";
            txtCantidadAsientos.Text = " ";
            cbEstado.Checked = false;
            txtDescripcion.Text = " ";
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
