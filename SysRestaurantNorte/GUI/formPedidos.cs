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
    public partial class formPedidos : Form
    {
        public formPedidos()
        {
            InitializeComponent();

            groupBox.Enabled = false;
        }
        private void LimpiarCampos()
        {

            dgvDetalle.DataSource=" ";//observar si se borra los datos de la tabla
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {

            groupBox.Enabled = true;
            LimpiarCampos();
        }
    }
}
