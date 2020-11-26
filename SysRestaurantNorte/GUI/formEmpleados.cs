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
    public partial class formEmpleados : Form
    {
        public formEmpleados()
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
        txtRol.Text = " ";
        }
    /* dejar en blanco*/private void label7_Click(object sender, EventArgs e){}//el titulo dejar en blanco 

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
            btnGuardar.Visible = true;
            groupBox.Enabled = true;
            LimpiarCampos();
        }
    }
}
