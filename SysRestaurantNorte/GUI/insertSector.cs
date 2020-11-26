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
    public partial class insertSector : Form
    {
        Form1 main;
        bool editar =false;
        public insertSector(Form1 main)
        {
            this.main = main;
            InitializeComponent();
        }
        public insertSector(Form1 main, string id)
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
                        entSector c = new entSector();

                        c.id = inId.Text.Trim();
                        c.name = inName.Text.Trim();
                        c.price = Convert.ToSingle(inPrice.Value);
                        logSector.Instancia.insertarSector(c);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                    }
                    main.ListSector();
                    this.Close();
                }
            

            }
            else
            {
                entSector c = new entSector();

                c.id = inId.Text.Trim();
                c.name = inName.Text.Trim();
                c.price = Convert.ToSingle(inPrice.Value);

                logSector.Instancia.editarSector(c);
                main.ListSector();
                this.Close();
            }
            
           
        }
    }
}
