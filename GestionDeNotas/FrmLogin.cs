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
using BLL;


namespace GestionDeNotas
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIconIngresar_Click(object sender, EventArgs e)
        {
            List<Usuario> usuarios = new UsuarioService().Listar();
            Usuario usuario = new UsuarioService().Listar().Where(u=>u.IdUsuario == txtDocumento.Text && u.Clave == txtContraseña.Text).FirstOrDefault();
            if (usuario != null )
            {
                if (usuario.Rol == "ADMINISTRADOR")
                {
                   FrmInicio frmInicio = new FrmInicio(usuario);
                   frmInicio.Show();
                   this.Hide();
                    
                }
                else if (usuario.Rol == "DOCENTE")
                {
                    FrmUsuarios frmRegistro = new FrmUsuarios();
                    frmRegistro.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("No se encontro el usuario","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
    }
}
