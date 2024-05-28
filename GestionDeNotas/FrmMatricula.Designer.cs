namespace GestionDeNotas
{
    partial class FrmMatricula
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
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.cmbGradosEscolares = new System.Windows.Forms.ComboBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.btnIconBuscar = new FontAwesome.Sharp.IconButton();
            this.btnIconAsignar = new FontAwesome.Sharp.IconButton();
            this.dtgMatriculados = new System.Windows.Forms.DataGridView();
            this.cmbGradosFiltro = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Filtros = new System.Windows.Forms.GroupBox();
            this.btnIconFiltrar = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMatriculados)).BeginInit();
            this.Filtros.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grados Escolares";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identificacion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombres:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellidos:";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(47, 96);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(160, 20);
            this.txtIdentificacion.TabIndex = 4;
            // 
            // cmbGradosEscolares
            // 
            this.cmbGradosEscolares.FormattingEnabled = true;
            this.cmbGradosEscolares.Location = new System.Drawing.Point(157, 33);
            this.cmbGradosEscolares.Name = "cmbGradosEscolares";
            this.cmbGradosEscolares.Size = new System.Drawing.Size(160, 21);
            this.cmbGradosEscolares.TabIndex = 5;
            this.cmbGradosEscolares.Text = "SELECCIONE";
            // 
            // txtNombres
            // 
            this.txtNombres.Enabled = false;
            this.txtNombres.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(47, 153);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(160, 26);
            this.txtNombres.TabIndex = 6;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Enabled = false;
            this.txtApellidos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(47, 205);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(160, 26);
            this.txtApellidos.TabIndex = 7;
            // 
            // btnIconBuscar
            // 
            this.btnIconBuscar.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.btnIconBuscar.IconColor = System.Drawing.Color.Black;
            this.btnIconBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIconBuscar.IconSize = 20;
            this.btnIconBuscar.Location = new System.Drawing.Point(213, 94);
            this.btnIconBuscar.Name = "btnIconBuscar";
            this.btnIconBuscar.Size = new System.Drawing.Size(38, 22);
            this.btnIconBuscar.TabIndex = 8;
            this.btnIconBuscar.UseVisualStyleBackColor = true;
            this.btnIconBuscar.Click += new System.EventHandler(this.btnIconBuscar_Click);
            // 
            // btnIconAsignar
            // 
            this.btnIconAsignar.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.btnIconAsignar.IconColor = System.Drawing.Color.Black;
            this.btnIconAsignar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIconAsignar.IconSize = 20;
            this.btnIconAsignar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIconAsignar.Location = new System.Drawing.Point(135, 257);
            this.btnIconAsignar.Name = "btnIconAsignar";
            this.btnIconAsignar.Size = new System.Drawing.Size(73, 22);
            this.btnIconAsignar.TabIndex = 9;
            this.btnIconAsignar.Text = "Asignar";
            this.btnIconAsignar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIconAsignar.UseVisualStyleBackColor = true;
            this.btnIconAsignar.Click += new System.EventHandler(this.btnIconAsignar_Click);
            // 
            // dtgMatriculados
            // 
            this.dtgMatriculados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMatriculados.Location = new System.Drawing.Point(22, 72);
            this.dtgMatriculados.Name = "dtgMatriculados";
            this.dtgMatriculados.Size = new System.Drawing.Size(545, 189);
            this.dtgMatriculados.TabIndex = 10;
            // 
            // cmbGradosFiltro
            // 
            this.cmbGradosFiltro.FormattingEnabled = true;
            this.cmbGradosFiltro.Items.AddRange(new object[] {
            "TODOS",
            "SEXTO",
            "SEPTIMO",
            "OCTAVO",
            "NOVENO",
            "DECIMO",
            "ONCE"});
            this.cmbGradosFiltro.Location = new System.Drawing.Point(69, 30);
            this.cmbGradosFiltro.Name = "cmbGradosFiltro";
            this.cmbGradosFiltro.Size = new System.Drawing.Size(97, 21);
            this.cmbGradosFiltro.TabIndex = 12;
            this.cmbGradosFiltro.Text = "SELECCIONE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Grados:";
            // 
            // Filtros
            // 
            this.Filtros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Filtros.Controls.Add(this.btnIconFiltrar);
            this.Filtros.Controls.Add(this.cmbGradosFiltro);
            this.Filtros.Controls.Add(this.dtgMatriculados);
            this.Filtros.Controls.Add(this.label5);
            this.Filtros.Location = new System.Drawing.Point(464, 52);
            this.Filtros.Name = "Filtros";
            this.Filtros.Size = new System.Drawing.Size(646, 306);
            this.Filtros.TabIndex = 13;
            this.Filtros.TabStop = false;
            this.Filtros.Text = "Filtros";
            // 
            // btnIconFiltrar
            // 
            this.btnIconFiltrar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnIconFiltrar.IconColor = System.Drawing.Color.Black;
            this.btnIconFiltrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIconFiltrar.Location = new System.Drawing.Point(185, 28);
            this.btnIconFiltrar.Name = "btnIconFiltrar";
            this.btnIconFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnIconFiltrar.TabIndex = 13;
            this.btnIconFiltrar.Text = "Filtrar";
            this.btnIconFiltrar.UseVisualStyleBackColor = true;
            this.btnIconFiltrar.Click += new System.EventHandler(this.btnIconFiltrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnIconAsignar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnIconBuscar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.txtIdentificacion);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Controls.Add(this.cmbGradosEscolares);
            this.groupBox1.Location = new System.Drawing.Point(124, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 306);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1272, 22);
            this.panel1.TabIndex = 15;
            // 
            // FrmMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 445);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Filtros);
            this.Name = "FrmMatricula";
            this.Text = "Matricula";
            this.Load += new System.EventHandler(this.FrmMatricula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMatriculados)).EndInit();
            this.Filtros.ResumeLayout(false);
            this.Filtros.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.ComboBox cmbGradosEscolares;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private FontAwesome.Sharp.IconButton btnIconBuscar;
        private FontAwesome.Sharp.IconButton btnIconAsignar;
        private System.Windows.Forms.DataGridView dtgMatriculados;
        private System.Windows.Forms.ComboBox cmbGradosFiltro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox Filtros;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnIconFiltrar;
        private System.Windows.Forms.Panel panel1;
    }
}