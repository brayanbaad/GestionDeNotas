using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entity;
using System.Net.Mail;

namespace DAL
{
    public class DocenteRepository
    {
        SqlConnection connection;
        List<Docente> docentes;
        public DocenteRepository(ConnectionManager Connection) {

            connection = Connection.connection;
            docentes = new List<Docente>();
        }

        public void Registrar(Docente docente)
        {
            using (var comando = connection.CreateCommand())
            {
                comando.CommandText = " Insert  Into docente (identificacion,nombres,apellidos,fechaNacimiento,direccion,especialidad,telefono)" +
                   "Values(@identificacion,@nombres,@apellidos,@fechaNacimiento,@direccion,@especialidad,@telefono)";
                comando.Parameters.AddWithValue("@identificacion", docente.Identificacion);
                comando.Parameters.AddWithValue("@nombres", docente.Nombres);
                comando.Parameters.AddWithValue("@apellidos", docente.Apellidos);
                comando.Parameters.AddWithValue("@fechaNacimiento", docente.FechaNacimiento);
                comando.Parameters.AddWithValue("@direccion", docente.Direccion);
                comando.Parameters.AddWithValue("@especialidad", docente.Especialidad);
                comando.Parameters.AddWithValue("@telefono", docente.Telefono);
                comando.ExecuteNonQuery();
            }
        }

        public void Modificar(Docente docente)
        {
            using (var comando = connection.CreateCommand())
            {
                comando.CommandText = "Update docente set  nombres=@nombres,apellidos=@apellidos,fechaNacimiento=@fechaNacimiento,direccion=@direccion,especialidad=@especialidad,telefono=@telefono where identificacion = @identificacion";
                comando.Parameters.AddWithValue("@identificacion", docente.Identificacion);
                comando.Parameters.AddWithValue("@nombres", docente.Nombres);
                comando.Parameters.AddWithValue("@apellidos", docente.Apellidos);
                comando.Parameters.AddWithValue("@fechaNacimiento", docente.FechaNacimiento);
                comando.Parameters.AddWithValue("@direccion", docente.Direccion);
                comando.Parameters.AddWithValue("@especialidad", docente.Especialidad);
                comando.Parameters.AddWithValue("@telefono", docente.Telefono);
                comando.ExecuteNonQuery();
            }
        }

        public void Eliminar(string identificacion)
        {
            using (var comanddo = connection.CreateCommand())
            {
                comanddo.CommandText = " delete from docente where identificacion = @identificacion";
                comanddo.Parameters.AddWithValue("@identificacion", identificacion);
                comanddo.ExecuteNonQuery();
            }
        }
        public List<Docente> Consultar()
        {
            using (var comando = connection.CreateCommand())
            {
                comando.CommandText = "Select * from docente";
                var Reader = comando.ExecuteReader();
                while (Reader.Read())
                {
                    Docente docente = new Docente();
                    docente = Mapear(Reader);
                    docentes.Add(docente);

                }
            }
            return docentes;
        }

        public Docente BuscarId(string identificacion)
        {
            using (var Comando = connection.CreateCommand())
            {
                Comando.CommandText = "Select * from docente where identificacion =@identificacion";
                Comando.Parameters.AddWithValue("@identificacion", identificacion);
                var Reader = Comando.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        Docente docente = new Docente();
                        docente = Mapear(Reader);
                        return docente;
                    }
                }
            }
            return null;
        }

        public Docente Mapear(SqlDataReader reader)
        {
            Docente docente = new Docente();
            docente.Id = Convert.ToInt32(reader["ID"]);
            docente.Identificacion = (string)reader["identificacion"];
            docente.Nombres = (string)reader["nombres"];
            docente.Apellidos = (string)reader["apellidos"];
            docente.FechaNacimiento = (string)reader["fechaNacimiento"];
            docente.Direccion = (string)reader["direccion"];
            docente.Especialidad = (string)reader["especialidad"];
            docente.Telefono = (string)reader["telefono"];
            return docente;
        }

        public List<Docente> BuscarContiene(string nombre)
        {
            docentes = Consultar();
            return docentes.Where(p => p.Nombres.Contains(nombre)).ToList();
        }

    }
}
