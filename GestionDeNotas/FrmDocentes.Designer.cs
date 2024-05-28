namespace GestionDeNotas
{
    partial class FrmDocentes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.btnIconLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnIconEliminar = new FontAwesome.Sharp.IconButton();
            this.btnIconModificar = new FontAwesome.Sharp.IconButton();
            this.btnIconRegistrar = new FontAwesome.Sharp.IconButton();
            this.btnIconBuscar = new FontAwesome.Sharp.IconButton();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.dtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdentificacionBuscar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombreBuscar = new System.Windows.Forms.TextBox();
            this.dtgDocentes = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDocentes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 22);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.cmbEspecialidad);
            this.groupBox1.Controls.Add(this.btnIconLimpiar);
            this.groupBox1.Controls.Add(this.btnIconEliminar);
            this.groupBox1.Controls.Add(this.btnIconModificar);
            this.groupBox1.Controls.Add(this.btnIconRegistrar);
            this.groupBox1.Controls.Add(this.btnIconBuscar);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.dtFechaNacimiento);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIdentificacion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(49, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(951, 180);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion Personal";
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Items.AddRange(new object[] {
            "SELECCIONE"});
            this.cmbEspecialidad.Location = new System.Drawing.Point(644, 65);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(121, 21);
            this.cmbEspecialidad.TabIndex = 22;
            // 
            // btnIconLimpiar
            // 
            this.btnIconLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnIconLimpiar.IconColor = System.Drawing.Color.Black;
            this.btnIconLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIconLimpiar.IconSize = 20;
            this.btnIconLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIconLimpiar.Location = new System.Drawing.Point(832, 142);
            this.btnIconLimpiar.Name = "btnIconLimpiar";
            this.btnIconLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnIconLimpiar.TabIndex = 21;
            this.btnIconLimpiar.Text = "Limpiar";
            this.btnIconLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIconLimpiar.UseVisualStyleBackColor = true;
            this.btnIconLimpiar.Click += new System.EventHandler(this.btnIconLimpiar_Click);
            // 
            // btnIconEliminar
            // 
            this.btnIconEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnIconEliminar.IconColor = System.Drawing.Color.Black;
            this.btnIconEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIconEliminar.IconSize = 20;
            this.btnIconEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIconEliminar.Location = new System.Drawing.Point(832, 104);
            this.btnIconEliminar.Name = "btnIconEliminar";
            this.btnIconEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnIconEliminar.TabIndex = 20;
            this.btnIconEliminar.Text = "Eliminar";
            this.btnIconEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIconEliminar.UseVisualStyleBackColor = true;
            this.btnIconEliminar.Click += new System.EventHandler(this.btnIconEliminar_Click);
            // 
            // btnIconModificar
            // 
            this.btnIconModificar.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnIconModificar.IconColor = System.Drawing.Color.Black;
            this.btnIconModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIconModificar.IconSize = 20;
            this.btnIconModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIconModificar.Location = new System.Drawing.Point(832, 65);
            this.btnIconModificar.Name = "btnIconModificar";
            this.btnIconModificar.Size = new System.Drawing.Size(75, 23);
            this.btnIconModificar.TabIndex = 19;
            this.btnIconModificar.Text = "Modificar";
            this.btnIconModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIconModificar.UseVisualStyleBackColor = true;
            this.btnIconModificar.Click += new System.EventHandler(this.btnIconModificar_Click);
            // 
            // btnIconRegistrar
            // 
            this.btnIconRegistrar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnIconRegistrar.IconColor = System.Drawing.Color.Black;
            this.btnIconRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIconRegistrar.IconSize = 20;
            this.btnIconRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIconRegistrar.Location = new System.Drawing.Point(832, 26);
            this.btnIconRegistrar.Name = "btnIconRegistrar";
            this.btnIconRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnIconRegistrar.TabIndex = 18;
            this.btnIconRegistrar.Text = "Registrar";
            this.btnIconRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIconRegistrar.UseVisualStyleBackColor = true;
            this.btnIconRegistrar.Click += new System.EventHandler(this.btnIconRegistrar_Click);
            // 
            // btnIconBuscar
            // 
            this.btnIconBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnIconBuscar.IconColor = System.Drawing.Color.Black;
            this.btnIconBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIconBuscar.IconSize = 20;
            this.btnIconBuscar.Location = new System.Drawing.Point(229, 26);
            this.btnIconBuscar.Name = "btnIconBuscar";
            this.btnIconBuscar.Size = new System.Drawing.Size(37, 25);
            this.btnIconBuscar.TabIndex = 17;
            this.btnIconBuscar.UseVisualStyleBackColor = true;
            this.btnIconBuscar.Click += new System.EventHandler(this.btnIconBuscar_Click);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(629, 28);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(165, 20);
            this.txtApellidos.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(553, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Especialidad:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(296, 70);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(239, 20);
            this.txtDireccion.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Direccion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(571, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Apellidos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(102, 122);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(150, 20);
            this.txtTelefono.TabIndex = 10;
            // 
            // dtFechaNacimiento
            // 
            this.dtFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaNacimiento.Location = new System.Drawing.Point(113, 67);
            this.dtFechaNacimiento.Name = "dtFechaNacimiento";
            this.dtFechaNacimiento.Size = new System.Drawing.Size(106, 20);
            this.dtFechaNacimiento.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha Nacimiento:";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(87, 29);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(136, 20);
            this.txtIdentificacion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Identificacion:";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(371, 28);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(194, 20);
            this.txtNombres.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtIdentificacionBuscar);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtNombreBuscar);
            this.groupBox2.Controls.Add(this.dtgDocentes);
            this.groupBox2.Location = new System.Drawing.Point(49, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(937, 297);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(369, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Identificacion  Buscar:";
            // 
            // txtIdentificacionBuscar
            // 
            this.txtIdentificacionBuscar.Location = new System.Drawing.Point(487, 19);
            this.txtIdentificacionBuscar.Name = "txtIdentificacionBuscar";
            this.txtIdentificacionBuscar.Size = new System.Drawing.Size(150, 20);
            this.txtIdentificacionBuscar.TabIndex = 14;
            this.txtIdentificacionBuscar.TextChanged += new System.EventHandler(this.txtIdentificacionBuscar_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Nombre Buscar:";
            // 
            // txtNombreBuscar
            // 
            this.txtNombreBuscar.Location = new System.Drawing.Point(173, 19);
            this.txtNombreBuscar.Name = "txtNombreBuscar";
            this.txtNombreBuscar.Size = new System.Drawing.Size(150, 20);
            this.txtNombreBuscar.TabIndex = 12;
            this.txtNombreBuscar.TextChanged += new System.EventHandler(this.txtNombreBuscar_TextChanged);
            // 
            // dtgDocentes
            // 
            this.dtgDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDocentes.Location = new System.Drawing.Point(38, 45);
            this.dtgDocentes.Name = "dtgDocentes";
            this.dtgDocentes.Size = new System.Drawing.Size(847, 231);
            this.dtgDocentes.TabIndex = 0;
            this.dtgDocentes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDocentes_CellDoubleClick);
            // 
            // FrmDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 533);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDocentes";
            this.Text = "FrmConsultaUsuarios";
            this.Load += new System.EventHandler(this.FrmDocentes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDocentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtFechaNacimiento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgDocentes;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton btnIconBuscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombreBuscar;
        private FontAwesome.Sharp.IconButton btnIconLimpiar;
        private FontAwesome.Sharp.IconButton btnIconEliminar;
        private FontAwesome.Sharp.IconButton btnIconModificar;
        private FontAwesome.Sharp.IconButton btnIconRegistrar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIdentificacionBuscar;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
    }
}