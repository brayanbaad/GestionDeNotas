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
        public void Registrar(Estudiante estudiante)
        {
            using ( var comando = connection.CreateCommand())
            {
                comando.CommandText = " Insert  Into estudiante (identificacion,nombres,apellidos,correo,fechaNacimiento,direccion,telefono,promedio)" +
                   "Values(@identificacion,@nombres,@apellidos,@correo,@fechaNacimiento,@direccion,@telefono,@promedio)";
                comando.Parameters.AddWithValue("@identificacion", estudiante.Identificacion);
                comando.Parameters.AddWithValue("@nombres", estudiante.Nombres);
                comando.Parameters.AddWithValue("@apellidos", estudiante.Apellidos);
                comando.Parameters.AddWithValue("@correo", estudiante.Email.Address);
                comando.Parameters.AddWithValue("@fechaNacimiento", estudiante.FechaNacimiento);
                comando.Parameters.AddWithValue("@direccion", estudiante.Direccion);
                comando.Parameters.AddWithValue("@telefono", estudiante.Telefono);
                comando.Parameters.AddWithValue("@promedio", estudiante.Promedio);
                comando.ExecuteNonQuery();
            }
        }

        public void Modificar(Estudiante estudiante)
        {
            using (var comando = connection.CreateCommand())
            {
                comando.CommandText = "Update estudiante set  nombres=@nombres,apellidos=@apellidos,correo=@correo,fechaNacimiento=@fechaNacimiento,direccion=@direccion,telefono=@telefono where identificacion = @identificacion";
                comando.Parameters.AddWithValue("@identificacion", estudiante.Identificacion);
                comando.Parameters.AddWithValue("@nombres", estudiante.Nombres);
                comando.Parameters.AddWithValue("@apellidos", estudiante.Apellidos);
                comando.Parameters.AddWithValue("@correo", estudiante.Email.Address);
                comando.Parameters.AddWithValue("@fechaNacimiento", estudiante.FechaNacimiento);
                comando.Parameters.AddWithValue("@direccion", estudiante.Direccion);
                comando.Parameters.AddWithValue("@telefono", estudiante.Telefono);
                comando.ExecuteNonQuery();
            }
        }

        public void Eliminar(string identificacion)
        {
            using ( var comanddo = connection.CreateCommand())
            {
                comanddo.CommandText = " delete from estudiante where identificacion = @identificacion";
                comanddo.Parameters.AddWithValue("@identificacion", identificacion);
                comanddo.ExecuteNonQuery();
            }
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

        public Estudiante BuscarId(string identificacion)
        {
            using (var Comando = connection.CreateCommand())
            {
                Comando.CommandText = "Select * from estudiante where identificacion =@identificacion";
                Comando.Parameters.AddWithValue("@identificacion", identificacion);
                var Reader = Comando.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        Estudiante estudiante  = new Estudiante();
                        estudiante = Mapear(Reader);
                        return estudiante;
                    }
                }
            }
            return null;
        }

        public Estudiante Mapear(SqlDataReader reader)
        {
            Estudiante estudiante = new Estudiante();
            estudiante.Id = Convert.ToInt32(reader["ID"]);
            estudiante.Identificacion = (string)reader["identificacion"];
            estudiante.Nombres = (string)reader["nombres"];
            estudiante.Apellidos = (string)reader["apellidos"];
            estudiante.Email = new MailAddress((string)reader["correo"]);
            estudiante.FechaNacimiento = (string)reader["fechaNacimiento"];
            estudiante.Telefono = (string)reader["telefono"];
            estudiante.Direccion = (string)reader["direccion"];
            estudiante.Promedio = Convert.ToDecimal(reader["promedio"]);
            return estudiante;
        }

        

    }
}
