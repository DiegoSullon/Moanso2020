namespace GUI
{
    partial class insertPlat
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.inId = new System.Windows.Forms.TextBox();
            this.inName = new System.Windows.Forms.TextBox();
            this.inDescrp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inEstado = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "NOMBRE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "PRECIO:";
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(137, 324);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(86, 23);
            this.registerButton.TabIndex = 10;
            this.registerButton.Text = "REGISTRAR";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // inId
            // 
            this.inId.Location = new System.Drawing.Point(216, 62);
            this.inId.Name = "inId";
            this.inId.Size = new System.Drawing.Size(173, 20);
            this.inId.TabIndex = 11;
            // 
            // inName
            // 
            this.inName.Location = new System.Drawing.Point(158, 135);
            this.inName.Name = "inName";
            this.inName.Size = new System.Drawing.Size(231, 20);
            this.inName.TabIndex = 12;
            // 
            // inDescrp
            // 
            this.inDescrp.Location = new System.Drawing.Point(158, 186);
            this.inDescrp.Name = "inDescrp";
            this.inDescrp.Size = new System.Drawing.Size(231, 20);
            this.inDescrp.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "DESCRIPCION:";
            // 
            // inEstado
            // 
            this.inEstado.AutoSize = true;
            this.inEstado.Location = new System.Drawing.Point(294, 239);
            this.inEstado.Name = "inEstado";
            this.inEstado.Size = new System.Drawing.Size(80, 17);
            this.inEstado.TabIndex = 16;
            this.inEstado.Text = "checkBox1";
            this.inEstado.UseVisualStyleBackColor = true;
            this.inEstado.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // insertPlat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 407);
            this.Controls.Add(this.inEstado);
            this.Controls.Add(this.inDescrp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inName);
            this.Controls.Add(this.inId);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "insertPlat";
            this.Text = "Insertar";
            this.Load += new System.EventHandler(this.insertPlat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox inId;
        private System.Windows.Forms.TextBox inName;
        private System.Windows.Forms.TextBox inDescrp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox inEstado;
    }
}