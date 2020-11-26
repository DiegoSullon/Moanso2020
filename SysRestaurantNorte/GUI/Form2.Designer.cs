namespace GUI
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.listestado = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listseats = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonver = new System.Windows.Forms.Button();
            this.buttoneliminar = new System.Windows.Forms.Button();
            this.buttoneditar = new System.Windows.Forms.Button();
            this.buttonagregar = new System.Windows.Forms.Button();
            this.groupBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.listestado);
            this.groupBoxDatos.Controls.Add(this.label2);
            this.groupBoxDatos.Controls.Add(this.txtdesc);
            this.groupBoxDatos.Controls.Add(this.label1);
            this.groupBoxDatos.Controls.Add(this.button1);
            this.groupBoxDatos.Controls.Add(this.listseats);
            this.groupBoxDatos.Controls.Add(this.label6);
            this.groupBoxDatos.Controls.Add(this.txtid);
            this.groupBoxDatos.Controls.Add(this.label5);
            this.groupBoxDatos.Location = new System.Drawing.Point(221, 12);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(565, 376);
            this.groupBoxDatos.TabIndex = 13;
            this.groupBoxDatos.TabStop = false;
            // 
            // listestado
            // 
            this.listestado.AutoSize = true;
            this.listestado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.listestado.Location = new System.Drawing.Point(148, 324);
            this.listestado.Name = "listestado";
            this.listestado.Size = new System.Drawing.Size(128, 26);
            this.listestado.TabIndex = 15;
            this.listestado.Text = "OCUPADO";
            this.listestado.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "ESTADO :";
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(206, 214);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(221, 20);
            this.txtdesc.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "DESCRIPCION :";
            // 
            // listseats
            // 
            this.listseats.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.listseats.FormattingEnabled = true;
            this.listseats.ItemHeight = 22;
            this.listseats.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.listseats.Location = new System.Drawing.Point(233, 117);
            this.listseats.Name = "listseats";
            this.listseats.Size = new System.Drawing.Size(191, 26);
            this.listseats.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "NUMERO DE SILLAS :";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(233, 37);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(114, 20);
            this.txtid.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "NUMERO DE MESA :";
            // 
            // panelContenedor
            // 
            this.panelContenedor.Location = new System.Drawing.Point(215, 12);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(800, 450);
            this.panelContenedor.TabIndex = 16;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // logo
            // 
            this.logo.Image = global::GUI.Properties.Resources.LOGO;
            this.logo.Location = new System.Drawing.Point(324, 74);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(295, 333);
            this.logo.TabIndex = 15;
            this.logo.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::GUI.Properties.Resources.add_40px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(382, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 47);
            this.button1.TabIndex = 11;
            this.button1.Text = "AGREGAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonver
            // 
            this.buttonver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonver.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.buttonver.Image = global::GUI.Properties.Resources.table_40px;
            this.buttonver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonver.Location = new System.Drawing.Point(30, 341);
            this.buttonver.Name = "buttonver";
            this.buttonver.Size = new System.Drawing.Size(167, 46);
            this.buttonver.TabIndex = 4;
            this.buttonver.Text = "VER MESAS";
            this.buttonver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonver.UseVisualStyleBackColor = true;
            this.buttonver.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttoneliminar
            // 
            this.buttoneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttoneliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.buttoneliminar.Image = global::GUI.Properties.Resources.delete_40px;
            this.buttoneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttoneliminar.Location = new System.Drawing.Point(30, 236);
            this.buttoneliminar.Name = "buttoneliminar";
            this.buttoneliminar.Size = new System.Drawing.Size(167, 46);
            this.buttoneliminar.TabIndex = 2;
            this.buttoneliminar.Text = "ELIMINAR";
            this.buttoneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttoneliminar.UseVisualStyleBackColor = true;
            this.buttoneliminar.Click += new System.EventHandler(this.buttoneliminar_Click);
            // 
            // buttoneditar
            // 
            this.buttoneditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttoneditar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.buttoneditar.Image = global::GUI.Properties.Resources.edit_40px;
            this.buttoneditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttoneditar.Location = new System.Drawing.Point(30, 125);
            this.buttoneditar.Name = "buttoneditar";
            this.buttoneditar.Size = new System.Drawing.Size(167, 45);
            this.buttoneditar.TabIndex = 1;
            this.buttoneditar.Text = "EDITAR";
            this.buttoneditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttoneditar.UseVisualStyleBackColor = true;
            this.buttoneditar.Click += new System.EventHandler(this.buttoneditar_Click);
            // 
            // buttonagregar
            // 
            this.buttonagregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonagregar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonagregar.Image = global::GUI.Properties.Resources.add_40px;
            this.buttonagregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonagregar.Location = new System.Drawing.Point(30, 12);
            this.buttonagregar.Name = "buttonagregar";
            this.buttonagregar.Size = new System.Drawing.Size(167, 47);
            this.buttonagregar.TabIndex = 0;
            this.buttonagregar.Text = "AGREGAR";
            this.buttonagregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonagregar.UseVisualStyleBackColor = true;
            this.buttonagregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.buttonver);
            this.Controls.Add(this.buttoneliminar);
            this.Controls.Add(this.buttoneditar);
            this.Controls.Add(this.buttonagregar);
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "MESAS - RESTAURANT DEL NORTE";
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonagregar;
        private System.Windows.Forms.Button buttoneditar;
        private System.Windows.Forms.Button buttoneliminar;
        private System.Windows.Forms.Button buttonver;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.CheckBox listestado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listseats;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panelContenedor;
    }
}