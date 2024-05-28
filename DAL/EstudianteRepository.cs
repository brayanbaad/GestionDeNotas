using System;
using System.Collections.Generic;
using System.Data;
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
                comando.CommandText = "sp_crud_estudiante ";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@intProceso", 2);
                comando.Parameters.AddWithValue("@idEstudiante", estudiante.IdEstudiante);
                comando.Parameters.AddWithValue("@nombres", estudiante.Nombres);
                comando.Parameters.AddWithValue("@apellidos", estudiante.Apellidos);
                comando.Parameters.AddWithValue("@correo", estudiante.Email.Address);
                comando.Parameters.AddWithValue("@fechaNacimiento", estudiante.FechaNacimiento);
                comando.Parameters.AddWithValue("@direccion", estudiante.Direccion);
                comando.Parameters.AddWithValue("@telefono", estudiante.Telefono);
                comando.ExecuteNonQuery();
            }
        }

        public void Modificar(Estudiante estudiante)
        {
            using (var comando = connection.CreateCommand())
            {
                comando.CommandText = "sp_crud_estudiante";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@intProceso", 3);
                comando.Parameters.AddWithValue("@idEstudiante", estudiante.IdEstudiante);
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
            using ( var comando = connection.CreateCommand())
            {
                comando.CommandText = "sp_crud_estudiante";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@intProceso", 4);
                comando.Parameters.AddWithValue("@idEstudiante", identificacion);
                comando.ExecuteNonQuery();
            }
        }
        public List<Estudiante> Consultar()
        {
            using (var comando = connection.CreateCommand())
            {
                comando.CommandText = "sp_crud_estudiante";
                comando.CommandType = CommandType.StoredProcedure;
                // Añadir todos los parámetros necesarios
                comando.Parameters.AddWithValue("@intProceso", 1);
                comando.Parameters.AddWithValue("@item", DBNull.Value);
                comando.Parameters.AddWithValue("@idEstudiante", DBNull.Value);
                comando.Parameters.AddWithValue("@nombres", DBNull.Value);
                comando.Parameters.AddWithValue("@apellidos", DBNull.Value);
                comando.Parameters.AddWithValue("@correo", DBNull.Value);
                comando.Parameters.AddWithValue("@fechaNacimiento", DBNull.Value);
                comando.Parameters.AddWithValue("@direccion", DBNull.Value);
                comando.Parameters.AddWithValue("@telefono", DBNull.Value);

                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var estudiante = Mapear(reader);
                        estudiantes.Add(estudiante);
                    }
                }
            }
            
            return estudiantes;
        }

        
        public Estudiante Mapear(SqlDataReader reader)
        {
            
            var estudiante = new Estudiante
            {
                Item = reader.GetInt32(reader.GetOrdinal("item")),
                IdEstudiante = reader.GetString(reader.GetOrdinal("idEstudiante")),
                Nombres = reader.GetString(reader.GetOrdinal("nombres")),
                Apellidos = reader.GetString(reader.GetOrdinal("apellidos")),
                Email = new MailAddress(reader.GetString(reader.GetOrdinal("correo"))),
                FechaNacimiento = reader.GetString(reader.GetOrdinal("fechaNacimiento")),
                Telefono = reader.GetString(reader.GetOrdinal("telefono")),
                Direccion = reader.GetString(reader.GetOrdinal("direccion")),
                
            };
            return estudiante;
        }

        public List<Estudiante> BuscarContiene(string nombre)
        {
            estudiantes = Consultar();
            if (nombre =="")
            {
                return estudiantes;
            }
            else
            {
                return estudiantes.Where(estu => estu.IdEstudiante.Contains(nombre) || estu.Nombres.ToLower().Contains(nombre.ToLower())).ToList();
            }
        }

        public Estudiante BuscarId(string identificacion)
        {

            estudiantes = Consultar();
            return estudiantes.Where(estu => estu.IdEstudiante.Equals(identificacion)).FirstOrDefault();
            
        }


    }
}
