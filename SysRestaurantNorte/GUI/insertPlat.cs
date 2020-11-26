using Entity;
using Controller;
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
    public partial class insertPlat : Form
    {
        Form1 main;
        bool editar =false;
        public insertPlat(Form1 main)
        {
            this.main = main;
            InitializeComponent();
        }
        public insertPlat(Form1 main, string id)
        {
            editar = true;
            InitializeComponent();
            this.main = main;
            this.Text = "Editar";
            inId.Text = id;
            inId.Enabled = false;
            registerButton.Text = "Editar";
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!editar)
            {
                if (inId.Text.Length > 6)
                {
                    MessageBox.Show("Codigo invalido");
                }
                else
                {
                    try
                    {
                        entplatillo p = new entplatillo();

                        p.idPlatillo = Convert.ToInt32(inId);
                        p.nombrePlatillo = inName.Text.Trim();
                        p.descripcion = inDescrp.Text.Trim();
                        logplatillo.Instancia.insertarPlatillo(p);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                    }
                    main.Listplatillo();
                    this.Close();
                }
            

            }
            else
            {
                entplatillo p = new entplatillo();

                p.idPlatillo = Convert.ToInt32(inId);
                p.nombrePlatillo = inName.Text.Trim();
                p.descripcion = inDescrp.Text.Trim();
                p.estPlatillo = Convert.ToBoolean(inEstado);
                logplatillo.Instancia.insertarPlatillo(p);
                main.Listplatillo();
                this.Close();
            }
            
           
        }

        private void insertPlat_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
