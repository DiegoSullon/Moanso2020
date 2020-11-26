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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            panelContenedor.Hide();
            groupBoxDatos.Hide();
            groupBoxDatos.Enabled=false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBoxDatos.Show();
            logo.Hide();
            groupBoxDatos.Enabled = true;
            panelContenedor.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBoxDatos.Hide();
            logo.Hide();
            panelContenedor.Show();
            AbrirForm(new formMesas());
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AbrirForm(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fm1 = formhija as Form;
            fm1.TopLevel = false;
            fm1.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fm1);
            fm1.Show();
            
        }

        private void buttoneditar_Click(object sender, EventArgs e)
        {
            Table Tab = new Table();
            Tab.id = int.Parse(txtid.Text.Trim());
            Tab.seats = int.Parse(listseats.Text.Trim());
            Tab.description = txtdesc.Text.Trim();
            Tab.state = listestado.Checked;
            TableData.instance.edit(Tab);
            groupBoxDatos.Enabled = false;
            ListarCliente();
        }

        private void LimpiarVariables()
        {
            txtid.Text = " ";
            txtdesc.Text = " ";
            listseats.Text = " ";
            listestado.Checked = false;

        }

        public void ListarCliente()
        {
            //dgvCliente.DataSource = TableData.Instancia.list();
            //dgvCliente.Rows[dgvCliente.Rows.Count - 1].Selected = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Table Tab = new Table();
                Tab.id = int.Parse(txtid.Text.Trim());
                Tab.seats = int.Parse(listseats.Text.Trim());
                Tab.description = txtdesc.Text.Trim();
                Tab.state = listestado.Checked;
                TableData.instance.insert(Tab);
                /*
                   Tab.id = Convert.ToInt32(dr["idMesa"]);
               Tab.seats = Convert.ToInt32(dr["cantAsientos"]);
               Tab.description = dr["descripcion"].ToString();
               Tab.state = Convert.ToBoolean(dr["estMesa"]);
               */

                /*
                PerezEntidad c = new PerezEntidad();

                c.nombrePelicula = txtnombrePelicula.Text.Trim();
                c.idSala = int.Parse(txtidSala.Text.Trim());
                c.fecSala = dtfecSala.Value;
                c.estReserva = cbkestReserva.Checked;
                PerezLogica.Instancia.InsertaCliente(c);
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            LimpiarVariables();
            groupBoxDatos.Enabled = false;
            ListarCliente();
        }

        private void buttoneliminar_Click(object sender, EventArgs e)
        {
            Table Tab = new Table();
            Tab.id = 0;
            //DataGridViewRow filaActual = dgvCliente.CurrentRow;
            //Tab.id = int.Parse(filaActual.Cells[0].Value.ToString());
            //MessageBox.Show(idAsiento.ToString());
            TableData.instance.delete(Tab.id);
            ListarCliente();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

