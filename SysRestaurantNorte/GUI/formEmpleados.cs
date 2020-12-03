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
        txtApellido.Text = " ";
        txtNombre.Text = " ";
        txtDni.Text = " ";
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
            employe.idRol = txtRol.Text;
            employe.apellido = txtNombre.Text;
            employe.dni = txtNombre.Text;
            employe.cv = txtApellido.Text;
            employe.telefono = txtCorreo.Text;
            employe.fNacimiento = dtpFechaNacimiento.Value;
            if (edit)
            {
                employe.id = Convert.ToInt32(lbID.Text);
                ClientController.Instancia.editarSector(client);


            }
            else
            {
                ClientController.Instancia.insertarSector(client);
            }

            List();
            LimpiarCampos();
            groupBox.Enabled = false;
            edit = false;
        }

        private void bntBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
