using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entity;

namespace BLL
{
    
    public class EstudianteService
    {
        private ConnectionManager conexion;
        private EstudianteRepository estudianteRepository;
        List<Estudiante> estudiantes;
        Estudiante estudiante;
        public EstudianteService( string connectionString)
        {
           conexion = new ConnectionManager(connectionString);
           estudianteRepository = new EstudianteRepository(conexion);
          }

        public EstudianteService()
        {
            
        }

        public string Registrar(Estudiante estudiante)
        {
            try
            {
                conexion.Open();
                estudianteRepository.Registrar(estudiante);
                return $"Los datos del estudiante {estudiante.Nombres} ha sido registrado con exito";
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

        public List<Estudiante> Consultar()
        {
            try
            {
                estudiantes= new List<Estudiante>();
                conexion.Open();
                estudiantes = estudianteRepository.Consultar();
                return estudiantes;

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

        public Estudiante BuscarId(string identificacion)
        {
            try
            {
                conexion.Open();
                estudiante = new Estudiante();
                estudiante = estudianteRepository.BuscarId(identificacion);
                return estudiante;
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

         public  string Modificar(Estudiante estudiante)
        {
            try
            {
                conexion.Open();
                estudianteRepository.Modificar(estudiante);
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
                estudianteRepository.Eliminar(identificacion);
                return $"Los datos del estudiante han sido eliminados con exito";
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

        public void BuscarPalabra(string datos)
        {

        }




    }
}
