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
using System.Net.Mail;

namespace GestionDeNotas
{
    public partial class FrmEstudiante : Form
    {
        EstudianteService estudianteService;
        List<Estudiante> estudiantes;
        public FrmEstudiante()
        {
            InitializeComponent();
            estudianteService = new EstudianteService(ConfigConnection.connectionString);
            dtgEstudiantes.DataSource = estudianteService.Consultar();
            estudiantes = new List<Estudiante>();

        }

        private void Limpiar()
        {
            txtIdentificacion.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtCorreo.Text = "";
            dtFecha.Text = DateTime.Now.ToString();
        }

        

        private void dtgEstudiantes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtIdentificacion.Text = dtgEstudiantes.CurrentRow.Cells[1].Value.ToString();
            txtNombres.Text = dtgEstudiantes.CurrentRow.Cells[2].Value.ToString();
            txtApellidos.Text = dtgEstudiantes.CurrentRow.Cells[3].Value.ToString();
            txtCorreo.Text = dtgEstudiantes.CurrentRow.Cells[4].Value.ToString();
            dtFecha.Text = dtgEstudiantes.CurrentRow.Cells[5].Value.ToString();
            txtDireccion.Text = dtgEstudiantes.CurrentRow.Cells[6].Value.ToString();
            txtTelefono.Text = dtgEstudiantes.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnIconRegistrar_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante();
            estudiante.IdEstudiante =  txtIdentificacion.Text;
            estudiante.Nombres = txtNombres.Text;
            estudiante.Apellidos = txtApellidos.Text;
            estudiante.FechaNacimiento = dtFecha.Text;
            estudiante.Email = new MailAddress(txtCorreo.Text.Trim());
            estudiante.Direccion = txtDireccion.Text;
            estudiante.Telefono = txtTelefono.Text;
            string mensaje = estudianteService.Registrar(estudiante);
            MessageBox.Show(mensaje, "MENSAJE DE REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            estudianteService = new EstudianteService(ConfigConnection.connectionString);
            dtgEstudiantes.DataSource = estudianteService.Consultar();
            Limpiar();
        }

        private void btnIconModificar_Click(object sender, EventArgs e)
        {
            string identificacion = txtIdentificacion.Text;
            if (identificacion != "")
            {

                Estudiante estudiante = estudianteService.BuscarId(identificacion);
                if (estudiante != null)
                {
                    estudiante.Nombres = txtNombres.Text;
                    estudiante.Apellidos = txtApellidos.Text;
                    estudiante.FechaNacimiento = dtFecha.Text;
                    estudiante.Telefono = txtTelefono.Text;
                    estudiante.Direccion = txtDireccion.Text;
                    estudiante.Email = new MailAddress(txtCorreo.Text.ToString());
                    var respuestaa = MessageBox.Show("Esta seguro que desea modificar al estudiante?", "", MessageBoxButtons.YesNo);
                    if (respuestaa == DialogResult.Yes)
                    {
                        string mensaje = estudianteService.Modificar(estudiante);
                        MessageBox.Show(mensaje, "Mensaje de Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        estudianteService = new EstudianteService(ConfigConnection.connectionString);
                        dtgEstudiantes.DataSource = estudianteService.Consultar();
                        Limpiar();
                    }

                }
            }
        }

        private void btnIconEliminar_Click(object sender, EventArgs e)
        {
            string identificacion = txtIdentificacion.Text;
            if (identificacion != "")
            {
                Estudiante estudiante = estudianteService.BuscarId(identificacion);
                if (estudiante != null)
                {
                    var respuesta = MessageBox.Show("Esta seguro que desea eliminar este estudiante?", "", MessageBoxButtons.YesNo);
                    if (respuesta == DialogResult.Yes)
                    {
                        string mensaje = estudianteService.Eliminar(identificacion);
                        MessageBox.Show(mensaje, "MENSAJE DE ELIMINACION", MessageBoxButtons.OKCancel);
                        estudianteService = new EstudianteService(ConfigConnection.connectionString);
                        dtgEstudiantes.DataSource = estudianteService.Consultar();
                        Limpiar();
                    }
                }
                else
                {
                    MessageBox.Show($"La identificacion {identificacion} no esta en el sistema");

                }
            }
            else
            {
                MessageBox.Show("Digite la identifiacion del docente que desea buscar, por favor");
                txtIdentificacion.Focus();
            }
        }

        private void btnIconLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtNombreBuscar_TextChanged(object sender, EventArgs e)
        {
            string nombre = txtNombreBuscar.Text;
            estudianteService = new EstudianteService(ConfigConnection.connectionString);
            dtgEstudiantes.DataSource = estudianteService.BuscarContiene(nombre);
            
        }

        private void txtIdentificacionBuscar_TextChanged(object sender, EventArgs e)
        {
            string identificacion = txtIdentificacionBuscar.Text;
            estudianteService = new EstudianteService(ConfigConnection.connectionString);
            dtgEstudiantes.DataSource = estudianteService.BuscarContiene(identificacion);
        }

        
    }
}
