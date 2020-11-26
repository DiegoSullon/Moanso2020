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
using Controller;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ListSector();

    
   
           
        }
        public void ListSector()
        {
            dgvSectors.DataSource = logplatillo.Instancia.listarPlatillos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            insertPlat insertForm = new insertPlat(this);
            insertForm.Show();

        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            string id = "";
            DataGridViewRow filaActual = dgvSectors.CurrentRow;
            id = filaActual.Cells[0].Value.ToString();
            insertPlat edit = new insertPlat(this, id);
            edit.Show();
        }


        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            string id="";
            DataGridViewRow filaActual = dgvSectors.CurrentRow;
            id = filaActual.Cells[0].Value.ToString();
            //MessageBox.Show(idCliente.ToString());
            logplatillo.Instancia.eliminarPlatillo(id);
            ListSector();
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string search = "";
            List<entplatillo> lista = logplatillo.Instancia.listarPlatillos();
            List<entplatillo> lista2 = new List<entplatillo>();
            search = inSearch.Text;

            for (int i=0;i<lista.Count;i++)
            {
                if(lista[i].idPlatillo.Contains(search)|| lista[i].nombrePlatillo.Contains(search))
                {
                    lista2.Add(lista[i]);
                }
            }

            dgvSectors.DataSource = lista2;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
