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
            dgvSectors.DataSource = ClientController.Instancia.listarSectors();
          
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            insertSector insertForm = new insertSector(this);
            insertForm.Show();

        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            string id = "";
            DataGridViewRow filaActual = dgvSectors.CurrentRow;
            id = filaActual.Cells[0].Value.ToString();
            insertSector edit = new insertSector(this, id);
            edit.Show();
        }


        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            int id=0;
            DataGridViewRow filaActual = dgvSectors.CurrentRow;
            id = Convert.ToInt32( filaActual.Cells[0]);
            //MessageBox.Show(idCliente.ToString());
            ClientController.Instancia.eliminarSector(id);
            ListSector();
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            /*
            string search = "";
            List<Client> lista = ClientController.Instancia.listarSectors();
            List<Client> lista2 = new List<Client>();
            search = inSearch.Text;

            for (int i=0;i<lista.Count;i++)
            {
                if(lista[i].id.Contains(search)|| lista[i].name.Contains(search))
                {
                    lista2.Add(lista[i]);
                }
            }

            dgvSectors.DataSource = lista2;
            */

        }
    }
}
