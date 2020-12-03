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
    public partial class formMesa : Form
    {
        bool edit = false;
        public formMesa()
        {
            InitializeComponent();
            rbID.Checked = true;
            groupBox.Enabled = false;
            ListTable();
        }
        public void ListTable()
        {
            dgvLista.DataSource = TableController.instance.list();

        }
        private void LimpiarCampos()
        {
            lbID.Text = "";
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Table tab = new Table();
            
            tab.seats = Convert.ToInt32(spnCantidadAsientos.Value);
            tab.state = cbEstado.Checked;
            tab.description = txtDescripcion.Text;
            if (edit)
            {
                tab.id = Convert.ToInt32(lbID.Text);
                TableController.instance.edit(tab);


            }
            else
            {
                TableController.instance.insert(tab);
            }

            ListTable();
            LimpiarCampos();
            groupBox.Enabled = false;
            edit = false;
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = 0;
            DataGridViewRow fila = dgvLista.CurrentRow;
            id = Convert.ToInt32(fila.Cells[0].Value);
            //MessageBox.Show(fila.Cells[0].Value.ToString() );
            TableController.instance.delete(id);
            ListTable();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaActual = dgvLista.CurrentRow;
            lbID.Text = filaActual.Cells[0].Value.ToString();
            spnCantidadAsientos.Value = Convert.ToInt32(filaActual.Cells[1].Value);
            txtDescripcion.Text = filaActual.Cells[2].Value.ToString();
            cbEstado.Checked =  Convert.ToBoolean(filaActual.Cells[3].Value);
            
            btnGuardar.Enabled = true;
            btnGuardar.Visible = true;
            groupBox.Enabled = true;
            edit = true;
        }

        private void btnListarT_Click(object sender, EventArgs e)
        {
            ListTable();
        }

        private void bntBuscar_Click(object sender, EventArgs e)
        {
            string search = "";
            List<Table> lista = TableController.instance.list();
            List<Table> lista2 = new List<Table>();
            search = txtBuscador.Text;

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].id.ToString().Contains(search) || lista[i].seats.ToString().Contains(search) || lista[i].description.Contains(search))
                {
                    lista2.Add(lista[i]);
                }
            }

            dgvLista.DataSource = lista2;
        }
    }
}
