namespace GestionDeNotas
{
    partial class FrmInicio
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.menuDocentes = new FontAwesome.Sharp.IconMenuItem();
            this.menuMaterias = new FontAwesome.Sharp.IconMenuItem();
            this.menuEstudiantes = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.contenedor = new System.Windows.Forms.Panel();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuarios,
            this.menuDocentes,
            this.menuMaterias,
            this.menuEstudiantes,
            this.iconMenuItem1});
            this.menu.Location = new System.Drawing.Point(0, 48);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1180, 71);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.AutoSize = false;
            this.menuUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.menuUsuarios.IconColor = System.Drawing.Color.Black;
            this.menuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuUsuarios.IconSize = 30;
            this.menuUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.Size = new System.Drawing.Size(122, 67);
            this.menuUsuarios.Text = "Usuarios";
            this.menuUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuUsuarios.Click += new System.EventHandler(this.menuUsuarios_Click);
            // 
            // menuDocentes
            // 
            this.menuDocentes.AutoSize = false;
            this.menuDocentes.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            this.menuDocentes.IconColor = System.Drawing.Color.Black;
            this.menuDocentes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuDocentes.IconSize = 40;
            this.menuDocentes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuDocentes.Name = "menuDocentes";
            this.menuDocentes.Size = new System.Drawing.Size(122, 67);
            this.menuDocentes.Text = "Docentes";
            this.menuDocentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuDocentes.Click += new System.EventHandler(this.menuDocentes_Click);
            // 
            // menuMaterias
            // 
            this.menuMaterias.AutoSize = false;
            this.menuMaterias.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.menuMaterias.IconColor = System.Drawing.Color.Black;
            this.menuMaterias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuMaterias.IconSize = 30;
            this.menuMaterias.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuMaterias.Name = "menuMaterias";
            this.menuMaterias.Size = new System.Drawing.Size(122, 67);
            this.menuMaterias.Text = "Materias";
            this.menuMaterias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuEstudiantes
            // 
            this.menuEstudiantes.AutoSize = false;
            this.menuEstudiantes.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.menuEstudiantes.IconColor = System.Drawing.Color.Black;
            this.menuEstudiantes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuEstudiantes.IconSize = 35;
            this.menuEstudiantes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuEstudiantes.Name = "menuEstudiantes";
            this.menuEstudiantes.Size = new System.Drawing.Size(122, 67);
            this.menuEstudiantes.Text = "Estudiantes";
            this.menuEstudiantes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuEstudiantes.Click += new System.EventHandler(this.menuEstudiantes_Click);
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.AutoSize = false;
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.PenClip;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.IconSize = 35;
            this.iconMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(122, 67);
            this.iconMenuItem1.Text = "Notas";
            this.iconMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(1180, 48);
            this.menuTitulo.TabIndex = 1;
            this.menuTitulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(470, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "SISTEMA DE NOTAS";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblUsuario.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(60, 14);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(59, 15);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "lbusuario";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.btnSalir.IconColor = System.Drawing.Color.White;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 30;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.Location = new System.Drawing.Point(1061, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // contenedor
            // 
            this.contenedor.Location = new System.Drawing.Point(23, 122);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1145, 536);
            this.contenedor.TabIndex = 7;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1180, 670);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menu;
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInicio";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem menuUsuarios;
        private FontAwesome.Sharp.IconMenuItem menuDocentes;
        private FontAwesome.Sharp.IconMenuItem menuMaterias;
        private FontAwesome.Sharp.IconMenuItem menuEstudiantes;
        private System.Windows.Forms.Label lblUsuario;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconButton btnSalir;
        private System.Windows.Forms.Panel contenedor;
    }
}