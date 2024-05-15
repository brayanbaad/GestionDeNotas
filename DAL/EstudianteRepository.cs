using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace DAL
{
    public class EstudianteRepository
    {
        SqlConnection connection;
        List<Estudiante> estudiantes;
        public EstudianteRepository(ConnectionManager Connection)
        {
            connection = Connection.connection;
            estudiantes = new List<Estudiante>();

        }

        public List<Estudiante> Consultar()
        {
            using (var comando = connection.CreateCommand())
            {
                comando.CommandText = "Select * from estudiante";
                var Reader = comando.ExecuteReader();
                while (Reader.Read())
                {
                    Estudiante estudiante = new Estudiante();
                    estudiante = Mapear(Reader);
                    estudiantes.Add(estudiante);

                }
            }
            return estudiantes;
        }

        public Estudiante Mapear(SqlDataReader reader)
        {
            Estudiante estudiante = new Estudiante();
            estudiante.Id = Convert.ToInt32(reader["ID"]);
            estudiante.Identificacion = (string)reader["identificacion"];
            estudiante.Nombres = (string)reader["nombres"];
            estudiante.Apellidos = (string)reader["apellidos"];
            estudiante.Email = new MailAddress((string)reader["correo"]);
            estudiante.FechaNacimiento = Convert.ToDateTime((string)reader["fechaNacimiento"]);
            estudiante.Telefono = (string)reader["telefono"];
            estudiante.Direccion = (string)reader["direccion"];
            estudiante.Promedio = Convert.ToDecimal(reader["promedio"]);
            return estudiante;
        }
    }
}
