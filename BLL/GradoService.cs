using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GradoService
    {
        private ConnectionManager conexion;
        GradoRepository gradoRepository;
        List<Grado> grados;
        public GradoService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            gradoRepository = new GradoRepository(conexion);
        }

        public List<Grado> CargarGrados()
        {
            try
            {
                grados = new List<Grado>();
                conexion.Open();
                grados = gradoRepository.CargarGrados();
                return grados;

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
