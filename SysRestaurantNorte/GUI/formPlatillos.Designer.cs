
namespace GUI
{
    partial class formPlatillos
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
            this.btnListarT = new System.Windows.Forms.Button();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rbID = new System.Windows.Forms.RadioButton();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.lbID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.bntBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.spnPrecio = new System.Windows.Forms.NumericUpDown();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnPrecio)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListarT
            // 
            this.btnListarT.BackColor = System.Drawing.Color.DarkOrange;
            this.btnListarT.FlatAppearance.BorderSize = 0;
            this.btnListarT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarT.ForeColor = System.Drawing.Color.White;
            this.btnListarT.Location = new System.Drawing.Point(671, 169);
            this.btnListarT.Margin = new System.Windows.Forms.Padding(4);
            this.btnListarT.Name = "btnListarT";
            this.btnListarT.Size = new System.Drawing.Size(193, 25);
            this.btnListarT.TabIndex = 38;
            this.btnListarT.Text = "LISTAR TODO";
            this.btnListarT.UseVisualStyleBackColor = false;
            this.btnListarT.Click += new System.EventHandler(this.btnListarT_Click);
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(45, 207);
            this.dgvLista.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowHeadersWidth = 51;
            this.dgvLista.Size = new System.Drawing.Size(819, 198);
            this.dgvLista.TabIndex = 36;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(126, 50);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(189, 27);
            this.txtNombre.TabIndex = 34;
            // 
            // txtBuscador
            // 
            this.txtBuscador.Location = new System.Drawing.Point(45, 167);
            this.txtBuscador.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(289, 22);
            this.txtBuscador.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(45, 132);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "Buscar por:";
            // 
            // rbID
            // 
            this.rbID.AutoSize = true;
            this.rbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbID.Location = new System.Drawing.Point(281, 132);
            this.rbID.Margin = new System.Windows.Forms.Padding(4);
            this.rbID.Name = "rbID";
            this.rbID.Size = new System.Drawing.Size(49, 24);
            this.rbID.TabIndex = 31;
            this.rbID.TabStop = true;
            this.rbID.Text = "ID";
            this.rbID.UseVisualStyleBackColor = true;
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbNombre.Location = new System.Drawing.Point(176, 132);
            this.rbNombre.Margin = new System.Windows.Forms.Padding(4);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(95, 24);
            this.rbNombre.TabIndex = 30;
            this.rbNombre.TabStop = true;
            this.rbNombre.Text = "Nombre";
            this.rbNombre.UseVisualStyleBackColor = true;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbID.Location = new System.Drawing.Point(64, 21);
            this.lbID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(47, 25);
            this.lbID.TabIndex = 29;
            this.lbID.Text = "-----";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(236, 44);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(589, 42);
            this.label7.TabIndex = 28;
            this.label7.Text = "PLATILLOS DEL RESTAURANTE";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Green;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuevo.Location = new System.Drawing.Point(901, 207);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(132, 39);
            this.btnNuevo.TabIndex = 27;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
            // 
            // bntBuscar
            // 
            this.bntBuscar.BackColor = System.Drawing.Color.DarkOrange;
            this.bntBuscar.FlatAppearance.BorderSize = 0;
            this.bntBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntBuscar.ForeColor = System.Drawing.Color.White;
            this.bntBuscar.Location = new System.Drawing.Point(344, 167);
            this.bntBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.bntBuscar.Name = "bntBuscar";
            this.bntBuscar.Size = new System.Drawing.Size(100, 25);
            this.bntBuscar.TabIndex = 26;
            this.bntBuscar.Text = "BUSCAR";
            this.bntBuscar.UseVisualStyleBackColor = false;
            this.bntBuscar.Click += new System.EventHandler(this.formPlatillos_Load);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(901, 254);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(132, 39);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.button1);
            this.groupBox.Controls.Add(this.label6);
            this.groupBox.Controls.Add(this.dataGridView1);
            this.groupBox.Controls.Add(this.groupBox1);
            this.groupBox.Controls.Add(this.spnPrecio);
            this.groupBox.Controls.Add(this.txtNombre);
            this.groupBox.Controls.Add(this.btnGuardar);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.txtDescripcion);
            this.groupBox.Controls.Add(this.lbID);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox.Location = new System.Drawing.Point(35, 426);
            this.groupBox.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox.Size = new System.Drawing.Size(1008, 288);
            this.groupBox.TabIndex = 37;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Datos Del Platillo";
            // 
            // spnPrecio
            // 
            this.spnPrecio.Location = new System.Drawing.Point(126, 104);
            this.spnPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.spnPrecio.Name = "spnPrecio";
            this.spnPrecio.Size = new System.Drawing.Size(189, 27);
            this.spnPrecio.TabIndex = 21;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Location = new System.Drawing.Point(866, 225);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(132, 39);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(8, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(11, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Precio : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID :";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(568, 230);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(261, 27);
            this.txtDescripcion.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(391, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 29);
            this.label5.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(403, 227);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tiempo";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditar.Location = new System.Drawing.Point(901, 301);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(132, 39);
            this.btnEditar.TabIndex = 39;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(16, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 113);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo Platillo";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(104, 25);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Segundo";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(125, 26);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(98, 25);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Entrada";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(245, 26);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(91, 25);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Bebida";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(568, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(261, 174);
            this.dataGridView1.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(403, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 29);
            this.label6.TabIndex = 36;
            this.label6.Text = "Ingredientes";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(866, 28);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 39);
            this.button1.TabIndex = 40;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOrange;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(901, 348);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 39);
            this.button2.TabIndex = 41;
            this.button2.Text = "INGREDIENTES";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // formPlatillos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1067, 738);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnListarT);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.txtBuscador);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rbID);
            this.Controls.Add(this.rbNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.bntBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formPlatillos";
            this.Text = "formPlatillos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnPrecio)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarT;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbID;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button bntBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.NumericUpDown spnPrecio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button2;
    }
}