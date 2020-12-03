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
    public partial class formEmpleados : Form
    {
        private bool edit = false;
        private OpenFileDialog file = new OpenFileDialog();
        public formEmpleados()
        {
            InitializeComponent();
            rbID.Checked = true;
            groupBox.Enabled = false;
            List();
            combobox();
        }
        public void List()
        {
            dgvLista.DataSource = EmployeController.Instancia.listar();

        }
        private void combobox()
        {
            //Build a list
            var dataSource = RolData.Instancia.listar();

            //Setup data binding
            this.boxRol.DataSource = dataSource;
            this.boxRol.DisplayMember = "name";
            this.boxRol.ValueMember = "id";

            // make it readonly
            this.boxRol.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private void LimpiarCampos()
        {
            lbID.Text = "";
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtDni.Text = "";
            file.FileName = "";
            fileButton.Text = "Selecionar archivo";
        }
    /* dejar en blanco*/private void label7_Click(object sender, EventArgs e){}//el titulo dejar en blanco 

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
            btnGuardar.Visible = true;
            groupBox.Enabled = true;
            LimpiarCampos();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Employe employe = new Employe();
            employe.name = txtNombre.Text;
            employe.idRol = Convert.ToInt32(this.boxRol.SelectedValue);
            employe.apellido = txtApellido.Text;
            employe.dni = txtDni.Text;
            employe.cv = fileButton.Text;
            MessageBox.Show(employe.cv);
            employe.telefono = txtTelefono.Text;
            employe.fNacimiento = dtpFechaNacimiento.Value;

            if (edit)
            {
                employe.id = Convert.ToInt32(lbID.Text);
                EmployeController.Instancia.editar(employe, file);


            }
            else
            {
                EmployeController.Instancia.insertar(employe, file);
            }

            LimpiarCampos();
            groupBox.Enabled = false;
            edit = false;
            List();
        }

        private void bntBuscar_Click(object sender, EventArgs e)
        {
            string search = "";
            List<Employe> lista = EmployeController.Instancia.listar();
            List<Employe> lista2 = new List<Employe>();
            search = txtBuscador.Text;

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].dni.Contains(search) || lista[i].name.Contains(search) || lista[i].telefono.Contains(search) || lista[i].apellido.Contains(search))
                {
                    lista2.Add(lista[i]);
                }
            }

            dgvLista.DataSource = lista2;
        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            file.Filter = "PDF files (*.pdf)|*.pdf;";
            if (file.ShowDialog() == DialogResult.OK)
            {
            }
            if (file.FileName.Equals(""))
            {
                MessageBox.Show("Archivo no seleccionado");
            }
            else
            {
                //file.FileName= file.FileName.Replace(".pdf", Guid.NewGuid().ToString() + ".pdf");
                fileButton.Text = file.SafeFileName;
            }
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaActual = dgvLista.CurrentRow;
            lbID.Text = filaActual.Cells[0].Value.ToString();
            txtNombre.Text = filaActual.Cells[1].Value.ToString();
            boxRol.SelectedValue = filaActual.Cells[2].Value.ToString();
            txtApellido.Text = filaActual.Cells[3].Value.ToString();
            txtDni.Text = filaActual.Cells[4].Value.ToString();
            fileButton.Text = filaActual.Cells[5].Value.ToString();
            txtTelefono.Text = filaActual.Cells[6].Value.ToString();
            dtpFechaNacimiento.Value = Convert.ToDateTime(filaActual.Cells[7].Value);

            btnGuardar.Enabled = true;
            btnGuardar.Visible = true;
            groupBox.Enabled = true;
            edit = true;
        }

        private void linkCV_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string localFilePath = "";
            SaveFileDialog saveFile = new SaveFileDialog();
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                localFilePath = saveFile.FileName;
            }
            int id = 0;
            DataGridViewRow fila = dgvLista.CurrentRow;
            id = Convert.ToInt32(fila.Cells[0].Value);
            if (!saveFile.FileName.Equals("")&& !fila.Cells[5].Value.ToString().Equals("Selecionar archivo") && !fila.Cells[5].Value.ToString().Equals(""))
            {
                
                EmployeController.Instancia.downloadCv(localFilePath, fila.Cells[5].Value.ToString());
            }
            else
            {
                MessageBox.Show("CV No disponible");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = 0;
            DataGridViewRow fila = dgvLista.CurrentRow;
            id = Convert.ToInt32(fila.Cells[0].Value);
            EmployeController.Instancia.eliminar(id);
            List();
        }

        private void btnListarT_Click(object sender, EventArgs e)
        {
            List();
        }
    }
}
