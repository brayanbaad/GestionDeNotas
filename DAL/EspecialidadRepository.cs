using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class EspecialidadRepository
    {
        SqlConnection connection;
        List<Especialidad> especialidades;
        public EspecialidadRepository(ConnectionManager Connection)
        {
            connection = Connection.connection;
            especialidades = new List<Especialidad>();  
        }

        public void Registrar(Especialidad especialidad)
        {
            using (var comando = connection.CreateCommand())
            {
                comando.CommandText = " Insert  Into especialidad (nombre)" +
                   "Values(@nombre)";
                comando.Parameters.AddWithValue("@nombre", especialidad.Nombre);
                comando.ExecuteNonQuery();
            }
        }

        public void Modificar(Especialidad especialidad)
        {
            using (var comando = connection.CreateCommand())
            {
                comando.CommandText = "Update especialidad set  nombre=@nombre where idEspecialidad = @idEspecialidad";
                comando.Parameters.AddWithValue("@idEspecialidad", especialidad.idEspecialidad);
                comando.Parameters.AddWithValue("@nombre", especialidad.Nombre);
               
                comando.ExecuteNonQuery();
            }
        }

        public void Eliminar(string nombre)
        {
            using (var comanddo = connection.CreateCommand())
            {
                comanddo.CommandText = " delete from especialidad where nombre = @nombre";
                comanddo.Parameters.AddWithValue("@nombre", nombre);
                comanddo.ExecuteNonQuery();
            }
        }
        public List<Especialidad> Consultar()
        {
            using (var comando = connection.CreateCommand())
            {
                comando.CommandText = "Select * from especialidad";
                var Reader = comando.ExecuteReader();
                while (Reader.Read())
                {
                    Especialidad especialidad  = new Especialidad();
                    especialidad = Mapear(Reader);
                    especialidades.Add(especialidad);

                }
            }
            return especialidades;
        }

        public Especialidad BuscarId(string nombre)
        {
            using (var Comando = connection.CreateCommand())
            {
                Comando.CommandText = "Select * from especialidad where nombre =@nombre";
                Comando.Parameters.AddWithValue("@nombre", nombre);
                var Reader = Comando.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        Especialidad especialidad  = new Especialidad();
                        especialidad = Mapear(Reader);
                        return especialidad;
                    }
                }
            }
            return null;
        }

        public Especialidad Mapear(SqlDataReader reader)
        {
            Especialidad especialidad = new Especialidad();
            especialidad.idEspecialidad = Convert.ToInt32(reader["idEspecialidad"]);
            especialidad.Nombre = (string)reader["nombre"];
            return especialidad;
        }
    }
}
