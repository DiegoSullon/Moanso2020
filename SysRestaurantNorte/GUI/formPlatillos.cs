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

namespace GUI
{
    public partial class formPlatillos : Form
    {
        private bool edit = false;
        public formPlatillos()
        {
            InitializeComponent();
            ListPlatillos();
            ListIngredientes();
            groupBox.Enabled = false;
        }

        public void ListPlatillos()
        {
            dgvLista.DataSource = logplatillo.instance.listarPlatillos();
        }
        public void ListIngredientes()
        {
            dgvIngredientes.DataSource = IngredienteController.instance.list();
        }

        private void LimpiarCampos()
        {
            lbID.Text = "";
            txtTiempo.Text = " ";
            //cbEstado.Checked = false;
            txtNombre.Text = " ";
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
            IngredientePlatillo ingrepla = new IngredientePlatillo();
            DataGridViewRow filaActual1 = dgvIngredientes.CurrentRow;
            
            Platillo platillo = new Platillo();
            platillo.name = txtNombre.Text;
            platillo.precio= float.Parse(cbPrecio.Text); 
            if (rbSegundo.Checked)
            {
                platillo.tipoPlatilloId = 1;
            }
            else if (rbEntrada.Checked)
            {
                platillo.tipoPlatilloId = 2;
            }
            else if (rbBebida.Checked)
            {
                platillo.tipoPlatilloId = 3;
            }
            platillo.tPreparacion = txtTiempo.Text;

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
            ListIngredientes();
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
            ListIngredientes();
        }

        private void btnListarT_Click(object sender, EventArgs e)
        {
            ListPlatillos();
            ListIngredientes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string id = "";
            DataGridViewRow filaActual = dgvLista.CurrentRow;
            lbID.Text = filaActual.Cells[0].Value.ToString();
            txtNombre.Text = filaActual.Cells[1].Value.ToString();
            txtTiempo.Text = filaActual.Cells[2].Value.ToString();
            // cbEstado.Checked = Convert.ToBoolean(filaActual.Cells[3].Value);
            btnGuardar.Enabled = true;
            btnGuardar.Visible = true;
            groupBox.Enabled = true;
            edit = true;
        }

        private void formPlatillos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}