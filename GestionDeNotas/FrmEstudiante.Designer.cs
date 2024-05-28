namespace GestionDeNotas
{
    partial class FrmEstudiante
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIconLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnIconEliminar = new FontAwesome.Sharp.IconButton();
            this.btnIconModificar = new FontAwesome.Sharp.IconButton();
            this.btnIconRegistrar = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgEstudiantes = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombreBuscar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIdentificacionBuscar = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.btnIconLimpiar);
            this.groupBox1.Controls.Add(this.btnIconEliminar);
            this.groupBox1.Controls.Add(this.btnIconModificar);
            this.groupBox1.Controls.Add(this.btnIconRegistrar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtIdentificacion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtFecha);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(154, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(880, 238);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnIconLimpiar
            // 
            this.btnIconLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIconLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnIconLimpiar.IconColor = System.Drawing.Color.Black;
            this.btnIconLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIconLimpiar.IconSize = 20;
            this.btnIconLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIconLimpiar.Location = new System.Drawing.Point(618, 174);
            this.btnIconLimpiar.Name = "btnIconLimpiar";
            this.btnIconLimpiar.Size = new System.Drawing.Size(82, 29);
            this.btnIconLimpiar.TabIndex = 23;
            this.btnIconLimpiar.Text = "Limpiar";
            this.btnIconLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIconLimpiar.UseVisualStyleBackColor = true;
            this.btnIconLimpiar.Click += new System.EventHandler(this.btnIconLimpiar_Click);
            // 
            // btnIconEliminar
            // 
            this.btnIconEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIconEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnIconEliminar.IconColor = System.Drawing.Color.Black;
            this.btnIconEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIconEliminar.IconSize = 20;
            this.btnIconEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIconEliminar.Location = new System.Drawing.Point(459, 174);
            this.btnIconEliminar.Name = "btnIconEliminar";
            this.btnIconEliminar.Size = new System.Drawing.Size(82, 29);
            this.btnIconEliminar.TabIndex = 22;
            this.btnIconEliminar.Text = "Eliminar";
            this.btnIconEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIconEliminar.UseVisualStyleBackColor = true;
            this.btnIconEliminar.Click += new System.EventHandler(this.btnIconEliminar_Click);
            // 
            // btnIconModificar
            // 
            this.btnIconModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIconModificar.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnIconModificar.IconColor = System.Drawing.Color.Black;
            this.btnIconModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIconModificar.IconSize = 20;
            this.btnIconModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIconModificar.Location = new System.Drawing.Point(301, 174);
            this.btnIconModificar.Name = "btnIconModificar";
            this.btnIconModificar.Size = new System.Drawing.Size(92, 29);
            this.btnIconModificar.TabIndex = 21;
            this.btnIconModificar.Text = "Modificar";
            this.btnIconModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIconModificar.UseVisualStyleBackColor = true;
            this.btnIconModificar.Click += new System.EventHandler(this.btnIconModificar_Click);
            // 
            // btnIconRegistrar
            // 
            this.btnIconRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIconRegistrar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnIconRegistrar.IconColor = System.Drawing.Color.Black;
            this.btnIconRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIconRegistrar.IconSize = 20;
            this.btnIconRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIconRegistrar.Location = new System.Drawing.Point(145, 174);
            this.btnIconRegistrar.Name = "btnIconRegistrar";
            this.btnIconRegistrar.Size = new System.Drawing.Size(92, 29);
            this.btnIconRegistrar.TabIndex = 20;
            this.btnIconRegistrar.Text = "Registrar";
            this.btnIconRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIconRegistrar.UseVisualStyleBackColor = true;
            this.btnIconRegistrar.Click += new System.EventHandler(this.btnIconRegistrar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Correo:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(99, 109);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(197, 26);
            this.txtCorreo.TabIndex = 7;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(704, 18);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(146, 26);
            this.txtApellidos.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(635, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(704, 58);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(146, 26);
            this.txtTelefono.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(635, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Apellidos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(325, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Direccion:";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(399, 18);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(200, 26);
            this.txtNombres.TabIndex = 2;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(399, 58);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(200, 26);
            this.txtDireccion.TabIndex = 5;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(104, 12);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(133, 26);
            this.txtIdentificacion.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Identificacion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha:";
            // 
            // dtFecha
            // 
            this.dtFecha.CalendarFont = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFecha.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(99, 57);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(197, 25);
            this.dtFecha.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1140, 22);
            this.panel1.TabIndex = 3;
            // 
            // dtgEstudiantes
            // 
            this.dtgEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEstudiantes.Location = new System.Drawing.Point(174, 351);
            this.dtgEstudiantes.Name = "dtgEstudiantes";
            this.dtgEstudiantes.Size = new System.Drawing.Size(844, 146);
            this.dtgEstudiantes.TabIndex = 4;
            this.dtgEstudiantes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgEstudiantes_CellMouseClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(151, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Información Estudiante";
            // 
            // txtNombreBuscar
            // 
            this.txtNombreBuscar.Location = new System.Drawing.Point(329, 322);
            this.txtNombreBuscar.Name = "txtNombreBuscar";
            this.txtNombreBuscar.Size = new System.Drawing.Size(133, 20);
            this.txtNombreBuscar.TabIndex = 14;
            this.txtNombreBuscar.TextChanged += new System.EventHandler(this.txtNombreBuscar_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(225, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nombre Buscar:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(522, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Identificacion Buscar:";
            // 
            // txtIdentificacionBuscar
            // 
            this.txtIdentificacionBuscar.Location = new System.Drawing.Point(637, 325);
            this.txtIdentificacionBuscar.Name = "txtIdentificacionBuscar";
            this.txtIdentificacionBuscar.Size = new System.Drawing.Size(203, 20);
            this.txtIdentificacionBuscar.TabIndex = 18;
            this.txtIdentificacionBuscar.TextChanged += new System.EventHandler(this.txtIdentificacionBuscar_TextChanged);
            // 
            // FrmEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 549);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtIdentificacionBuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombreBuscar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtgEstudiantes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmEstudiante";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgEstudiantes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtNombreBuscar;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnIconRegistrar;
        private FontAwesome.Sharp.IconButton btnIconModificar;
        private FontAwesome.Sharp.IconButton btnIconEliminar;
        private FontAwesome.Sharp.IconButton btnIconLimpiar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIdentificacionBuscar;
    }
}