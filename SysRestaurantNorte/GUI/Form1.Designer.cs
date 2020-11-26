namespace GUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvSectors = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.inSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSectors)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSectors
            // 
            this.dgvSectors.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSectors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSectors.Location = new System.Drawing.Point(42, 34);
            this.dgvSectors.Name = "dgvSectors";
            this.dgvSectors.ReadOnly = true;
            this.dgvSectors.Size = new System.Drawing.Size(441, 263);
            this.dgvSectors.TabIndex = 0;
            this.dgvSectors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellContentClick);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(530, 125);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(112, 35);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(530, 235);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(112, 35);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(530, 56);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(112, 44);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(530, 183);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(111, 32);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Eliminar";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(338, 328);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(112, 35);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Buscar";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // inSearch
            // 
            this.inSearch.Location = new System.Drawing.Point(80, 336);
            this.inSearch.Name = "inSearch";
            this.inSearch.Size = new System.Drawing.Size(229, 20);
            this.inSearch.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 375);
            this.Controls.Add(this.inSearch);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvSectors);
            this.Name = "Form1";
            this.Text = "MantenedorSectores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSectors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSectors;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox inSearch;
    }
}

