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



    }
}
