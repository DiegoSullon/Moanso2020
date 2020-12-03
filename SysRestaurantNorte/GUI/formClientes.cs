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
using Data;
using Entity;

namespace GUI
{
    public partial class formClientes : Form
    {
        private bool edit = false;
        public formClientes()
        {
            InitializeComponent();
            ListClient();
            rbID.Checked = true;
            groupBox.Enabled = false;
            combobox();
        }
        public void ListClient()
        {
            dgvLista.DataSource = ClientController.Instancia.listarSectors();

        }
        private void combobox()
        {
            //Build a list
            var dataSource = CiudadData.Instancia.listar();

            //Setup data binding
            this.boxCiudad.DataSource = dataSource;
            this.boxCiudad.DisplayMember = "name";
            this.boxCiudad.ValueMember = "id";

            // make it readonly
            this.boxCiudad.DropDownStyle = ComboBoxStyle.DropDownList;

            var dataSource2 = TipoClienteData.Instancia.listar();
            //Setup data binding
            this.boxTipoCliente.DataSource = dataSource2;
            this.boxTipoCliente.DisplayMember = "name";
            this.boxTipoCliente.ValueMember = "id";

            // make it readonly
            this.boxTipoCliente.DropDownStyle = ComboBoxStyle.DropDownList;
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

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.ciudadId = Convert.ToInt32(this.boxCiudad.SelectedValue);
            client.tipoClienteId = Convert.ToInt32(this.boxTipoCliente.SelectedValue);
            client.dni = txtDni.Text;
            client.name = txtNombre.Text;
            client.apellidos = txtApellido.Text;
            client.email = txtCorreo.Text;
            client.ruc = txtRuc.Text;
            client.fNacmiento = dtpFechaNacimiento.Value;
            if (edit)
            {
                client.id = Convert.ToInt32(lbID.Text);
                ClientController.Instancia.editarSector(client);


            }
            else
            {
                ClientController.Instancia.insertarSector(client);
            }

            ListClient();
            LimpiarCampos();
            groupBox.Enabled = false;
            edit = false;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = 0;
            DataGridViewRow fila = dgvLista.CurrentRow;
            id = Convert.ToInt32(fila.Cells[0].Value);
            ClientController.Instancia.eliminarSector(id);
            ListClient();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaActual = dgvLista.CurrentRow;
            lbID.Text = filaActual.Cells[0].Value.ToString();
            boxCiudad.SelectedValue = filaActual.Cells[1].Value.ToString();
            boxTipoCliente.SelectedValue = filaActual.Cells[2].Value.ToString();
            txtDni.Text = filaActual.Cells[3].Value.ToString();
            txtNombre.Text = filaActual.Cells[4].Value.ToString();
            txtApellido.Text = filaActual.Cells[5].Value.ToString();
            txtCorreo.Text = filaActual.Cells[6].Value.ToString();
            txtRuc.Text = filaActual.Cells[7].Value.ToString();
            dtpFechaNacimiento.Value = Convert.ToDateTime(filaActual.Cells[8].Value);
            btnGuardar.Enabled = true;
            btnGuardar.Visible = true;
            groupBox.Enabled = true;
            edit = true;

        }

        private void btnListarT_Click(object sender, EventArgs e)
        {
            ListClient();
        }

        private void bntBuscar_Click(object sender, EventArgs e)
        {
            string search = "";
            List<Client> lista = ClientController.Instancia.listarSectors();
            List<Client> lista2 = new List<Client>();
            search = txtBuscador.Text;

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].dni.Contains(search) || lista[i].name.Contains(search)|| lista[i].email.Contains(search) || lista[i].apellidos.Contains(search))
                {
                    lista2.Add(lista[i]);
                }
            }

            dgvLista.DataSource = lista2;
        }

        private void boxCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
