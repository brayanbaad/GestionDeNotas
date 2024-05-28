using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MatriculaService
    {
        private ConnectionManager conexion;
        private MatriculaRepository matriculaRepository;
        List<Matricula> matriculas;
        public MatriculaService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            matriculaRepository = new MatriculaRepository(conexion);
        }

        public string Registrar(Matricula matricula)
        {
            try
            {
                conexion.Open();
                matriculaRepository.Registrar(matricula);
                return $"Los datos se han sido registrado con exito";
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

        public List<Matricula> Consultar()
        {
            try
            {
                matriculas = new List<Matricula>();
                conexion.Open();
                matriculas = matriculaRepository.Consultar();
                return matriculas;

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
        public List<Matricula> ListarTipo( string tipo)
        {
            try
            {
                matriculas = new List<Matricula>();
                conexion.Open();
                matriculas = matriculaRepository.ListarTipo(tipo);
                return matriculas;

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
    }
}
