using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Entity;
using Data;

namespace GUI
{
    public partial class formPlatillos : Form
    {
        private bool edit = false;
        public formPlatillos()
        {
            InitializeComponent();
            ListPlatillos();
            groupBox.Enabled = false;
        }

        public void ListPlatillos()
        {
            dgvLista.DataSource = logplatillo.instance.listarPlatillos();
        }

        private void LimpiarCampos()
        {
            lbID.Text = "";
            txtTiempo.Text = " ";
            txtNombre.Text = " ";
            rbSegundo.Checked = false;
            rbEntrada.Checked = false;
            rbBebida.Checked = false;
        }


        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            
            btnGuardar.Enabled = true; 
            btnGuardar.Visible = true;
            groupBox.Enabled = true;
            LimpiarCampos();
        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Platillo platillo = new Platillo();
            platillo.name = txtNombre.Text;


            if (edit)
            {
                platillo.id = Convert.ToInt32(lbID.Text);
                logplatillo.instance.editarPlatillo(platillo);

            }
            else
            {
                logplatillo.instance.insertarPlatillo(platillo);
            }

            ListPlatillos();
            LimpiarCampos();
            groupBox.Enabled = false;
            edit = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = 0;
            DataGridViewRow fila = dgvLista.CurrentRow;
            id = Convert.ToInt32(fila.Cells[0].Value);
            //MessageBox.Show(fila.Cells[0].Value.ToString() );
            logplatillo.instance.eliminarPlatillo(id);
            ListPlatillos();
        }

        private void btnListarT_Click(object sender, EventArgs e)
        {
            ListPlatillos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string id = "";
            DataGridViewRow filaActual = dgvLista.CurrentRow;
            lbID.Text = filaActual.Cells[0].Value.ToString();
            txtNombre.Text = filaActual.Cells[1].Value.ToString();
            txtTiempo.Text = filaActual.Cells[2].Value.ToString();
            btnGuardar.Enabled = true;
            btnGuardar.Visible = true;
            groupBox.Enabled = true;
            edit = true;
        }

        private void formPlatillos_Load(object sender, EventArgs e)
        {

        }
    }
}