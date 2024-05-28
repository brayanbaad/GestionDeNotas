using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EspecialidadService
    {
        private ConnectionManager conexion;
        private EspecialidadRepository especialidadRepository;
        List<Especialidad> especialidades;
        Especialidad especialidad;
        public EspecialidadService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            especialidadRepository= new EspecialidadRepository(conexion);

        }

        public string Registrar(Especialidad especialidad)
        {
            try
            {
                conexion.Open();
                especialidadRepository.Registrar(especialidad);
                return $"Los datos de la especialidad {especialidad.Nombre} ha sido registrado con exito";
            }
            catch (Exception e)
            {

                return $" error de base de datos {e.Message}";
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<Especialidad> Consultar()
        {
            try
            {
                especialidades = new List<Especialidad>();
                conexion.Open();
                especialidades = especialidadRepository.Consultar();
                return especialidades;

            }
            catch (Exception e)
            {
                string Mensaje = $"error de datos" + e.Message.ToString();
            }
            finally
            {
                conexion.Close();
            }
            return null;
        }

        public Especialidad BuscarId(string identificacion)
        {
            try
            {
                conexion.Open();
                especialidad = new Especialidad();
                especialidad = especialidadRepository.BuscarId(identificacion);
                return especialidad;
            }
            catch (Exception e)
            {
                string Mensaje = $"error de datos" + e.Message.ToString();
            }
            finally
            {
                conexion.Close();
            }
            return null;
        }

        public string Modificar(Especialidad especialidad )
        {
            try
            {
                conexion.Open();
                especialidadRepository.Modificar(especialidad);
                return "Registro Modificado correctamente";
            }
            catch (Exception e)
            {

                return $"Error de base de datos {e.Message.ToString()}";
            }
            finally
            {
                conexion.Close();
            }
        }

        public string Eliminar(string identificacion)
        {
            try
            {
                conexion.Open();
                especialidadRepository.Eliminar(identificacion);
                return $"Los datos de la especialidad han sido eliminados con exito";
            }
            catch (Exception e)
            {

                return $" error de base de datos {e.Message}";
            }
            finally
            {
                conexion.Close();
            }

        }
    }
}
