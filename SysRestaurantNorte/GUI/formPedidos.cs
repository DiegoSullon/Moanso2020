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
            platillosPedidos = new List<Platillo>();
            List();
            combobox();
        }
        public void List()
        {
            clientes = ClientController.Instancia.listarSectors();
            platillos = logplatillo.instance.listarPlatillos();
            dgvListaCliente.DataSource = clientes;
            dgvListaPlatillo.DataSource = platillos;
           

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
            listBox.Items.Clear();
            int count = Convert.ToInt32(numberCount.Value);
            DataGridViewRow fila = dgvListaPlatillo.CurrentRow;
            Platillo pla = new Platillo();
            pla.id = Convert.ToInt32(fila.Cells[0].Value);
            pla.name = fila.Cells[1].Value.ToString();
            pla.tipoPlatilloId = Convert.ToInt32(fila.Cells[2].Value);
            pla.tPreparacion = fila.Cells[3].Value.ToString(); 
            pla.precio = Convert.ToSingle(fila.Cells[4].Value);

            for (int i=0;i<count;i++)
            {
                platillosPedidos.Add(pla);
                
            }
            List<string> pnames = new List<string>();
            for (int i = 0; i < platillosPedidos.Count; i++)
            {
                pnames.Add(platillosPedidos[i].name);

            }
            listBox.Items.AddRange(pnames.ToArray());

            //List();
        }

        private void btnCrear_Pedido_Click(object sender, EventArgs e)
        {
            if (platillosPedidos.Count > 0)
            {
                Order ord = new Order();
                ord.idCliente = Convert.ToInt32(textCliente.Text);
                ord.idMesa = Convert.ToInt32(this.boxMesa.SelectedValue);
                ord.platillo = platillosPedidos;
                OrderController.instance.insert(ord);
                listBox.Items.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (platillosPedidos.Count > 0)
            {
                platillosPedidos.RemoveAt(platillosPedidos.Count - 1);
                listBox.Items.RemoveAt(listBox.Items.Count - 1);
            }
           
        }
    }
}
