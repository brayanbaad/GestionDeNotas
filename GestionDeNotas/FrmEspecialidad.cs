using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace GestionDeNotas
{
    public partial class FrmEspecialidad : Form
    {
        EspecialidadService especialidadService;
        List<Especialidad> especialidades;
        Especialidad especialidad;
        private string idEspecialidadItem;
        public FrmEspecialidad()
        {
            InitializeComponent();
            especialidadService = new EspecialidadService(ConfigConnection.connectionString);
            dtgEspecialidades.DataSource = especialidadService.Consultar();
            especialidades = new List<Especialidad>();


        }
        private void Limpiar()
        {
            txtNombreEspecialidad.Text = "";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Especialidad especialidad = new Especialidad();
            especialidad.Nombre =  txtNombreEspecialidad.Text;
            string mensaje = especialidadService.Registrar(especialidad);
            MessageBox.Show(mensaje, "MENSAJE DE REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            especialidadService = new EspecialidadService(ConfigConnection.connectionString);
            dtgEspecialidades.DataSource = especialidadService.Consultar();
            Limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreEspecialidad.Text;
            if (nombre != "")
            {
                especialidad = new Especialidad();
                especialidad.idEspecialidad = Convert.ToInt32(idEspecialidadItem);
                especialidad.Nombre = txtNombreEspecialidad.Text;
                var respuestaa = MessageBox.Show("Esta seguro que desea modificar la especialidad?", "", MessageBoxButtons.YesNo);
                if (respuestaa == DialogResult.Yes)
                {
                    string mensaje = especialidadService.Modificar(especialidad);
                    MessageBox.Show(mensaje, "Mensaje de Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    especialidadService = new EspecialidadService(ConfigConnection.connectionString);
                    dtgEspecialidades.DataSource = especialidadService.Consultar();
                    Limpiar();
                }
            }
        }
        private void dtgEspecialidades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idEspecialidadItem = dtgEspecialidades.CurrentRow.Cells[0].Value.ToString();
            txtNombreEspecialidad.Text = dtgEspecialidades.CurrentRow.Cells[1].Value.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }

}

