using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entity;
using System.Net.Mail;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DAL
{
    public class DocenteRepository
    {
        SqlConnection connection;
        List<Docente> docentes;
        List<Especialidad> especialidades;
        public DocenteRepository(ConnectionManager Connection) {

            connection = Connection.connection;
            docentes = new List<Docente>();
            especialidades = new List<Especialidad>();
        }

        public void Registrar(Docente docente)
        {
            using (var comando = connection.CreateCommand())
            {
                comando.CommandText = "sp_crud_docente";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@intProceso", 2);
                comando.Parameters.AddWithValue("@idDocente", docente.IdDocente);
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
                comando.CommandText = "sp_crud_docente";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@intProceso", 3);
                comando.Parameters.AddWithValue("@idDocente", docente.IdDocente);
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
            using (var comando = connection.CreateCommand())
            {
                comando.CommandText = "sp_crud_docente";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@intProceso", 4);
                comando.Parameters.AddWithValue("@idDocente", identificacion);
                comando.ExecuteNonQuery();
            }
        }
        public List<Docente> Consultar()
        {
            using (var comando = connection.CreateCommand())
            {
                comando.CommandText = "sp_crud_docente";
                comando.CommandType = CommandType.StoredProcedure;
                // Añadir todos los parámetros necesarios
                comando.Parameters.AddWithValue("@intProceso", 1);
                comando.Parameters.AddWithValue("@item", DBNull.Value);
                comando.Parameters.AddWithValue("@idDocente", DBNull.Value);
                comando.Parameters.AddWithValue("@nombres", DBNull.Value);
                comando.Parameters.AddWithValue("@apellidos", DBNull.Value);
                comando.Parameters.AddWithValue("@fechaNacimiento", DBNull.Value);
                comando.Parameters.AddWithValue("@direccion", DBNull.Value);
                comando.Parameters.AddWithValue("@especialidad", DBNull.Value);
                comando.Parameters.AddWithValue("@telefono", DBNull.Value);
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

       

        public Docente Mapear(SqlDataReader reader)
        {
            var docente = new Docente
            {
                Item = reader.GetInt32(reader.GetOrdinal("item")),
                IdDocente = reader.GetString(reader.GetOrdinal("idDocente")),
                Nombres = reader.GetString(reader.GetOrdinal("nombres")),
                Apellidos = reader.GetString(reader.GetOrdinal("apellidos")),
                FechaNacimiento = reader.GetString(reader.GetOrdinal("fechaNacimiento")),
                Direccion = reader.GetString(reader.GetOrdinal("direccion")),
                Especialidad = reader.GetString(reader.GetOrdinal("especialidad")),
                Telefono = reader.GetString(reader.GetOrdinal("telefono")),

            };

            return docente;
        }

        public List<Docente> BuscarContiene(string nombre)
        {
            docentes = Consultar();
            if (nombre == "")
            {
                return docentes;
            }
            else
            {
                return docentes.Where(p => p.IdDocente.Contains(nombre) || p.Nombres.ToLower().Contains(nombre.ToLower())).ToList();

            }
            
        }

        public Docente BuscarId(string identificacion)
        {

            docentes = Consultar();
            return docentes.Where(estu => estu.IdDocente.Equals(identificacion)).FirstOrDefault();

        }







    }
}
