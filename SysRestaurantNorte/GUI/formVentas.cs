using Controller;
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
    public partial class formVentas : Form
    {
        private List<Order> orders;
        public formVentas()
        {
            InitializeComponent();
            list();
        }
        private void list()
        {
            orders = OrderController.instance.list();
            dataPedidos.DataSource = orders;
            
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
            EmployeController.Instancia.eliminar(id);
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
    }
}
