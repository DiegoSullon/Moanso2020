using Controller;
using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;

namespace GUI
{
    public partial class formVentas : Form
    {
        private List<Order> orders;
        private List<Venta> ventas;
        public formVentas()
        {
            InitializeComponent();
            
            list();
        }
        private void list()
        {
            listBox.Items.Clear();
            orders = OrderController.instance.list();
            ventas = VentaData.Instancia.listar();
            List<string> pnames = new List<string>();
            for (int i = 0; i < ventas.Count; i++)
            {
                pnames.Add("ID: " + ventas[i].id.ToString() +" $"+ ventas[i].total.ToString() + " Fecha: " + ventas[i].fecha.ToString());

            }
            dataPedidos.DataSource = orders;
            listBox.Items.AddRange(pnames.ToArray());

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = 0;
            DataGridViewRow fila = dataPedidos.CurrentRow;
            id = Convert.ToInt32(fila.Cells[0].Value);
            List<Platillo> platillo = new List<Platillo>();
            for (int i=0;i<orders.Count; i++)
            {
                if (orders[i].id== id)
                {
                    platillo = orders[i].platillo;
                }
            }
            dataDetalles.DataSource = platillo;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = 0;
            float total=0;
            DataGridViewRow fila = dataPedidos.CurrentRow;
            id = Convert.ToInt32(fila.Cells[0].Value);
            Venta ven = new Venta();
            ven.metodoPagoID = 1;
            if (radioButton2.Checked)
            {
                ven.metodoPagoID = 2;
            }
            for (int i = 0; i < orders.Count; i++)
            {
                if (orders[i].id == id)
                {
                    for (int j = 0; j < orders[i].platillo.Count; j++)
                    {
                        total = total + orders[i].platillo[j].precio;
                    }
                }
            }
            ven.total = total;
            ven.pedidoID = id;
            ven.fecha = new DateTime();

            VentaData.Instancia.insertar(ven);
        }
    }
}
