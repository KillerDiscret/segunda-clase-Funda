namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.cbocarrera = new System.Windows.Forms.ComboBox();
            this.txtnrocursos = new System.Windows.Forms.TextBox();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btncontar = new System.Windows.Forms.Button();
            this.lboxlista = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Carrera profesional";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Número de cursos";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(159, 21);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(280, 20);
            this.txtcodigo.TabIndex = 4;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(159, 50);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(280, 20);
            this.txtnombre.TabIndex = 5;
            // 
            // cbocarrera
            // 
            this.cbocarrera.FormattingEnabled = true;
            this.cbocarrera.Items.AddRange(new object[] {
            "Ingenieria de sistemas",
            "Ingenieria de Software",
            "Ciencias de la Computacion",
            "Psicología"});
            this.cbocarrera.Location = new System.Drawing.Point(158, 136);
            this.cbocarrera.Name = "cbocarrera";
            this.cbocarrera.Size = new System.Drawing.Size(121, 21);
            this.cbocarrera.TabIndex = 6;
            // 
            // txtnrocursos
            // 
            this.txtnrocursos.Location = new System.Drawing.Point(452, 136);
            this.txtnrocursos.Name = "txtnrocursos";
            this.txtnrocursos.Size = new System.Drawing.Size(100, 20);
            this.txtnrocursos.TabIndex = 7;
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(50, 216);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(115, 41);
            this.btnregistrar.TabIndex = 8;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(241, 216);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(109, 41);
            this.btnbuscar.TabIndex = 9;
            this.btnbuscar.Text = "Buscar por codigo";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btncontar
            // 
            this.btncontar.Location = new System.Drawing.Point(438, 216);
            this.btncontar.Name = "btncontar";
            this.btncontar.Size = new System.Drawing.Size(114, 41);
            this.btncontar.TabIndex = 10;
            this.btncontar.Text = "contar por carrera";
            this.btncontar.UseVisualStyleBackColor = true;
            this.btncontar.Click += new System.EventHandler(this.btncontar_Click);
            // 
            // lboxlista
            // 
            this.lboxlista.FormattingEnabled = true;
            this.lboxlista.Location = new System.Drawing.Point(50, 298);
            this.lboxlista.Name = "lboxlista";
            this.lboxlista.Size = new System.Drawing.Size(531, 199);
            this.lboxlista.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 552);
            this.Controls.Add(this.lboxlista);
            this.Controls.Add(this.btncontar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.txtnrocursos);
            this.Controls.Add(this.cbocarrera);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.ComboBox cbocarrera;
        private System.Windows.Forms.TextBox txtnrocursos;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btncontar;
        private System.Windows.Forms.ListBox lboxlista;
    }
}

