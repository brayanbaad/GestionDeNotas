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
    public class DocenteService
    {
        private ConnectionManager conexion;
        private DocenteRepository docenteRepository;
        List<Docente> docentes;
        List<Especialidad> especialidades;
        public DocenteService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            docenteRepository = new DocenteRepository(conexion);
        }

        public string Registrar(Docente docente)
        {
            try
            {
                conexion.Open();
                docenteRepository.Registrar(docente);
                return $"Los datos del docente {docente.Nombres} ha sido registrado con exito";
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

        public List<Docente> Consultar()
        {
            try
            {
                docentes = new List<Docente>();
                conexion.Open();
                docentes = docenteRepository.Consultar();
                return docentes;

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

        public Docente BuscarId(string identificacion)
        {
            try
            {
                conexion.Open();
                Docente docente = new Docente();
                docente = docenteRepository.BuscarId(identificacion);
                return docente;
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

        public string Modificar(Docente docente)
        {
            try
            {
                conexion.Open();
                docenteRepository.Modificar(docente);
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
                docenteRepository.Eliminar(identificacion);
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
        public List<Docente> BuscarContiene(string nombre)
        {
            try
            {
                conexion.Open();
                List<Docente> docentes;
                docentes = docenteRepository.BuscarContiene(nombre);

                return docentes;
            }
            catch (Exception e)
            {

                string mensaje = $"error de datos{e.Message.ToString()}";
            }
            finally
            {
                conexion.Close();
            }
            return docentes;

        }
        
    }
}
