
namespace GUI
{
    partial class formPedidos
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
            this.label7 = new System.Windows.Forms.Label();
            this.dgvListaCliente = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvListaPlatillo = new System.Windows.Forms.DataGridView();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btnBuscarPlatillo = new System.Windows.Forms.Button();
            this.numberCount = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBuscarPlatillo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textCliente = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.btnCrear_Pedido = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.boxMesa = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPlatillo)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberCount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(183, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(432, 33);
            this.label7.TabIndex = 43;
            this.label7.Text = "PEDIDOS DEL RESTAURANTE";
            // 
            // dgvListaCliente
            // 
            this.dgvListaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCliente.Location = new System.Drawing.Point(220, 123);
            this.dgvListaCliente.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListaCliente.Name = "dgvListaCliente";
            this.dgvListaCliente.RowHeadersWidth = 51;
            this.dgvListaCliente.RowTemplate.Height = 24;
            this.dgvListaCliente.Size = new System.Drawing.Size(226, 147);
            this.dgvListaCliente.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(293, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 24);
            this.label5.TabIndex = 8;
            // 
            // dgvListaPlatillo
            // 
            this.dgvListaPlatillo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPlatillo.Location = new System.Drawing.Point(15, 62);
            this.dgvListaPlatillo.Name = "dgvListaPlatillo";
            this.dgvListaPlatillo.RowHeadersWidth = 51;
            this.dgvListaPlatillo.Size = new System.Drawing.Size(328, 210);
            this.dgvListaPlatillo.TabIndex = 51;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.btnBuscarPlatillo);
            this.groupBox.Controls.Add(this.numberCount);
            this.groupBox.Controls.Add(this.button1);
            this.groupBox.Controls.Add(this.txtBuscarPlatillo);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.dgvListaPlatillo);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox.Location = new System.Drawing.Point(22, 299);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(435, 288);
            this.groupBox.TabIndex = 52;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Platillos";
            // 
            // btnBuscarPlatillo
            // 
            this.btnBuscarPlatillo.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBuscarPlatillo.FlatAppearance.BorderSize = 0;
            this.btnBuscarPlatillo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPlatillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPlatillo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscarPlatillo.Location = new System.Drawing.Point(348, 28);
            this.btnBuscarPlatillo.Name = "btnBuscarPlatillo";
            this.btnBuscarPlatillo.Size = new System.Drawing.Size(73, 27);
            this.btnBuscarPlatillo.TabIndex = 59;
            this.btnBuscarPlatillo.Text = "BUSCAR";
            this.btnBuscarPlatillo.UseVisualStyleBackColor = false;
            // 
            // numberCount
            // 
            this.numberCount.Location = new System.Drawing.Point(348, 164);
            this.numberCount.Margin = new System.Windows.Forms.Padding(2);
            this.numberCount.Name = "numberCount";
            this.numberCount.Size = new System.Drawing.Size(72, 23);
            this.numberCount.TabIndex = 60;
            this.numberCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(349, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 32);
            this.button1.TabIndex = 59;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBuscarPlatillo
            // 
            this.txtBuscarPlatillo.Location = new System.Drawing.Point(167, 30);
            this.txtBuscarPlatillo.Name = "txtBuscarPlatillo";
            this.txtBuscarPlatillo.Size = new System.Drawing.Size(176, 23);
            this.txtBuscarPlatillo.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 58;
            this.label1.Text = "Buscar Platillo: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(27, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mesa : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(27, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 24);
            this.label6.TabIndex = 56;
            this.label6.Text = "ClienteID: ";
            // 
            // textCliente
            // 
            this.textCliente.Location = new System.Drawing.Point(125, 101);
            this.textCliente.Name = "textCliente";
            this.textCliente.Size = new System.Drawing.Size(72, 20);
            this.textCliente.TabIndex = 57;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(361, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(87, 20);
            this.textBox2.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(217, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 24);
            this.label8.TabIndex = 52;
            this.label8.Text = "Buscar Cliente: ";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscarCliente.Location = new System.Drawing.Point(453, 98);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(69, 20);
            this.btnBuscarCliente.TabIndex = 52;
            this.btnBuscarCliente.Text = "BUSCAR";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            // 
            // btnCrear_Pedido
            // 
            this.btnCrear_Pedido.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCrear_Pedido.FlatAppearance.BorderSize = 0;
            this.btnCrear_Pedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear_Pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear_Pedido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCrear_Pedido.Location = new System.Drawing.Point(206, 413);
            this.btnCrear_Pedido.Name = "btnCrear_Pedido";
            this.btnCrear_Pedido.Size = new System.Drawing.Size(106, 32);
            this.btnCrear_Pedido.TabIndex = 55;
            this.btnCrear_Pedido.Text = "Crear Pedido";
            this.btnCrear_Pedido.UseVisualStyleBackColor = false;
            this.btnCrear_Pedido.Click += new System.EventHandler(this.btnCrear_Pedido_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox);
            this.groupBox1.Controls.Add(this.btnCrear_Pedido);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(463, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 462);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle Pedido";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 17;
            this.listBox.Location = new System.Drawing.Point(15, 22);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(297, 378);
            this.listBox.TabIndex = 60;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(15, 413);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 32);
            this.button2.TabIndex = 59;
            this.button2.Text = "ELIMINAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(293, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 24);
            this.label4.TabIndex = 8;
            // 
            // boxMesa
            // 
            this.boxMesa.FormattingEnabled = true;
            this.boxMesa.Location = new System.Drawing.Point(125, 137);
            this.boxMesa.Margin = new System.Windows.Forms.Padding(2);
            this.boxMesa.Name = "boxMesa";
            this.boxMesa.Size = new System.Drawing.Size(72, 21);
            this.boxMesa.TabIndex = 59;
            // 
            // formPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.boxMesa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvListaCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formPedidos";
            this.Text = "formPedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPlatillo)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberCount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvListaCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvListaPlatillo;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textCliente;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnCrear_Pedido;
        private System.Windows.Forms.Button btnBuscarPlatillo;
        private System.Windows.Forms.NumericUpDown numberCount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBuscarPlatillo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox boxMesa;
        private System.Windows.Forms.ListBox listBox;
    }
}