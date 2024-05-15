using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using FontAwesome.Sharp;

namespace GestionDeNotas
{
    public partial class FrmInicio : Form
    {
        private static Usuario usuarioActual;
        private static IconMenuItem menuActivo = null;
        private static Form formularioActivo = null;
        public FrmInicio(Usuario usuario)
        {
            usuarioActual = usuario;
            InitializeComponent();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = usuarioActual.Rol.ToString();
        }
        private void AbrirFormulario(IconMenuItem menu,Form form)
        {
            if (menuActivo != null)
            {
                menuActivo.BackColor= Color.White;
            }
            menu.BackColor= Color.Silver;
            menuActivo = menu;
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            contenedor.Controls.Add(formularioActivo);
            form.Show();
        }
        private void menuUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmUsuarios());
        }

        private void menuDocentes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmDocentes());
        }

        private void menuEstudiantes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmEstudiante());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
