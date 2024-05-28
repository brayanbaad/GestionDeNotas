using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;
using System.Windows.Controls.Primitives;

namespace GestionDeNotas
{
    public partial class FrmMatricula : Form
    {
        MatriculaService matriculaService;
        EstudianteService estudianteService;
        GradoService gradoService;
        public FrmMatricula()
        {
            InitializeComponent();
            matriculaService = new MatriculaService(ConfigConnection.connectionString);
            estudianteService = new EstudianteService(ConfigConnection.connectionString);
            dtgMatriculados.DataSource = matriculaService.Consultar();

        }


        public void CargarGrados()
        {
            gradoService = new GradoService(ConfigConnection.connectionString);
            cmbGradosEscolares.DataSource = gradoService.CargarGrados();
            cmbGradosEscolares.DisplayMember = "nombre";
            cmbGradosEscolares.ValueMember = "idGrado";
        }

        private void FrmMatricula_Load(object sender, EventArgs e)
        {
            CargarGrados();
        }


        private void btnIconBuscar_Click(object sender, EventArgs e)
        {
            string identificacion = txtIdentificacion.Text;
            if (identificacion != "")
            {
                Estudiante estudiante = estudianteService.BuscarId(identificacion);
                if (estudiante != null)
                {
                    txtNombres.Text = estudiante.Nombres;
                    txtApellidos.Text = estudiante.Apellidos;
                }
                else
                {
                    MessageBox.Show("El estudiante no se encuentra en el sistema");

                }
            }
            else
            {
                MessageBox.Show("Digite la identifiacion del estudiante que desea buscar");
                txtIdentificacion.Focus();
            }
        }

        private void btnIconAsignar_Click(object sender, EventArgs e)
        {
            
            Matricula matricula = new Matricula();
            matricula.IdEstudiante = txtIdentificacion.Text;
            matricula.GradoEscolar = cmbGradosEscolares.SelectedIndex.ToString();
            string mensaje = matriculaService.Registrar(matricula);
            MessageBox.Show(mensaje, "MENSAJE DE REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            matriculaService = new MatriculaService(ConfigConnection.connectionString);
            dtgMatriculados.DataSource = matriculaService.Consultar();

        }

        private void btnIconFiltrar_Click(object sender, EventArgs e)
        {
            string tipo = cmbGradosFiltro.Text;
            if (tipo.Equals("TODOS"))
            {
                dtgMatriculados.DataSource = null;
                matriculaService = new MatriculaService(ConfigConnection.connectionString);
                dtgMatriculados.DataSource = matriculaService.Consultar();
            }
            else if (tipo.Equals("SEXTO"))
            {
                dtgMatriculados.DataSource = null;
                matriculaService = new MatriculaService(ConfigConnection.connectionString);
                dtgMatriculados.DataSource = matriculaService.ListarTipo(tipo);
            }
            else if (tipo.Equals("SEPTIMO"))
            {
                dtgMatriculados.DataSource = null;
                matriculaService = new MatriculaService(ConfigConnection.connectionString);
                dtgMatriculados.DataSource = matriculaService.ListarTipo(tipo);
            }
            else if (tipo.Equals("OCTAVO"))
            {
                dtgMatriculados.DataSource = null;
                matriculaService = new MatriculaService(ConfigConnection.connectionString);
                dtgMatriculados.DataSource = matriculaService.ListarTipo(tipo);
            }
            else if (tipo.Equals("NOVENO"))
            {
                dtgMatriculados.DataSource = null;
                matriculaService = new MatriculaService(ConfigConnection.connectionString);
                dtgMatriculados.DataSource = matriculaService.ListarTipo(tipo);
            }
            else if (tipo.Equals("DECIMO"))
            {
                dtgMatriculados.DataSource = null;
                matriculaService = new MatriculaService(ConfigConnection.connectionString);
                dtgMatriculados.DataSource = matriculaService.ListarTipo(tipo);
            }
            else if (tipo.Equals("ONCE"))
            {
                dtgMatriculados.DataSource = null;
                matriculaService = new MatriculaService(ConfigConnection.connectionString);
                dtgMatriculados.DataSource = matriculaService.ListarTipo(tipo);
            }
        }
    }
}
