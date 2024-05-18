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
    public partial class FrmDocentes : Form
    {
        DocenteService docenteService;
        List<Docente> docentes;  
        public FrmDocentes()
        {
            InitializeComponent();
            docenteService = new DocenteService(ConfigConnection.connectionString);
            dtgDocentes.DataSource = docenteService.Consultar();
            docentes = new List<Docente>(); 

        }


        private void Limpiar()
        {
            txtIdentificacion.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtEpecialidad.Text = "";
            dtFechaNacimiento.Text = DateTime.Now.ToString();
        }

        private void btnIconRegistrar_Click(object sender, EventArgs e)
        {
            Docente docente = new Docente();
            docente.Identificacion = txtIdentificacion.Text;
            docente.Nombres = txtNombres.Text;
            docente.Apellidos = txtApellidos.Text;
            docente.FechaNacimiento = dtFechaNacimiento.Text;
            docente.Direccion = txtDireccion.Text;
            docente.Especialidad = txtEpecialidad.Text;
            docente.Telefono = txtTelefono.Text;
            string mensaje = docenteService.Registrar(docente);
            MessageBox.Show(mensaje, "MENSAJE DE REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            docenteService = new DocenteService(ConfigConnection.connectionString);
            dtgDocentes.DataSource = docenteService.Consultar();
            Limpiar();
        }

        private void btnIconModificar_Click(object sender, EventArgs e)
        {
            string identificacion = txtIdentificacion.Text;
            if (identificacion != "")
            {

                Docente docente = docenteService.BuscarId(identificacion);
                if (docente != null)
                {
                    docente.Nombres = txtNombres.Text;
                    docente.Apellidos = txtApellidos.Text;
                    docente.FechaNacimiento = dtFechaNacimiento.Text;
                    docente.Direccion = txtDireccion.Text;
                    docente.Especialidad = txtEpecialidad.Text;
                    docente.Telefono = txtTelefono.Text;
                    var respuestaa = MessageBox.Show("Esta seguro que desea modificar al docente?", "", MessageBoxButtons.YesNo);
                    if (respuestaa == DialogResult.Yes)
                    {
                        string mensaje = docenteService.Modificar(docente);
                        MessageBox.Show(mensaje, "Mensaje de Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        docenteService = new DocenteService(ConfigConnection.connectionString);
                        dtgDocentes.DataSource = docenteService.Consultar();
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
                Docente docente = docenteService.BuscarId(identificacion);
                if (docente != null)
                {
                    var respuesta = MessageBox.Show("Esta seguro que desea eliminar este docente?", "", MessageBoxButtons.YesNo);
                    if (respuesta == DialogResult.Yes)
                    {
                        string mensaje = docenteService.Eliminar(identificacion);
                        MessageBox.Show(mensaje, "MENSAJE DE ELIMINACION", MessageBoxButtons.OKCancel);
                        docenteService = new DocenteService(ConfigConnection.connectionString);
                        dtgDocentes.DataSource = docenteService.Consultar();
                        Limpiar();
                    }
                }
                else
                {
                    MessageBox.Show($"La identificacion del docente {identificacion} no esta en el sistema");

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

        private void dtgDocentes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdentificacion.Text = dtgDocentes.CurrentRow.Cells[1].Value.ToString();
            txtNombres.Text = dtgDocentes.CurrentRow.Cells[2].Value.ToString();
            txtApellidos.Text = dtgDocentes.CurrentRow.Cells[3].Value.ToString();
            dtFechaNacimiento.Text = dtgDocentes.CurrentRow.Cells[4].Value.ToString();
            txtDireccion.Text = dtgDocentes.CurrentRow.Cells[5].Value.ToString();
            txtEpecialidad.Text = dtgDocentes.CurrentRow.Cells[6].Value.ToString();
            txtTelefono.Text = dtgDocentes.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnIconBuscar_Click(object sender, EventArgs e)
        {
            string identificacion = txtIdentificacion.Text;
            if (identificacion != "")
            {
                Docente docente = docenteService.BuscarId(identificacion);
                if (docente != null)
                {
                    txtNombres.Text = docente.Nombres;
                    txtApellidos.Text = docente.Apellidos;
                    dtFechaNacimiento.Text = docente.FechaNacimiento;
                    txtDireccion.Text = docente.Direccion;
                    txtEpecialidad.Text = docente.Especialidad;
                    txtTelefono.Text = docente.Telefono;
                }
                else
                {
                    MessageBox.Show("El docente no se encuentra registrado");

                }
            }
            else
            {
                MessageBox.Show("Digite la identifiacion del docente que desea buscar");
                txtIdentificacion.Focus();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombres.Text;
            if (nombre != "")
            {

                DocenteService docenteService = new DocenteService(ConfigConnection.connectionString);
                dtgDocentes.DataSource = docenteService.BuscarContiene(txtNombreBuscar.Text);
            }
            else
            {
                MessageBox.Show("Digite la cedula a consultar");
                txtNombreBuscar.Focus();
            }
        }
    }
}
