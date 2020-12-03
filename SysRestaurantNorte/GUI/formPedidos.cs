using Controller;
using Data;
using Entity;
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
        private List<Client> clientes;
        private List<Platillo> platillos;
        private List<Platillo> platillosPedidos;
        public formPedidos()
        {
            InitializeComponent();
            List();
            combobox();
        }
        public void List()
        {
            clientes = ClientController.Instancia.listarSectors();
            platillos = logplatillo.instance.listarPlatillos();
            dgvListaCliente.DataSource = clientes;
            dgvListaPlatillo.DataSource = platillos;
            //dgvListaDetalle.DataSource = ClientController.Instancia.listarSectors();

        }
        private void combobox()
        {
            //Build a list
            var dataSource = TableController.instance.list();

            //Setup data binding
            this.boxMesa.DataSource = dataSource;
            this.boxMesa.DisplayMember = "id";
            this.boxMesa.ValueMember = "id";

            // make it readonly
            this.boxMesa.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private void LimpiarCampos()
        {

            dgvListaPlatillo.DataSource=" ";//observar si se borra los datos de la tabla
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {

            groupBox.Enabled = true;
            LimpiarCampos();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
