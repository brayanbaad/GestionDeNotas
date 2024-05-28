using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class GradoRepository
    {
        SqlConnection connection;
        List<Grado> grados;
        public GradoRepository(ConnectionManager Connection)
        {
            connection = Connection.connection;
            grados = new List<Grado>();

        }
        public List<Grado> CargarGrados()
        {
            using (var comando = connection.CreateCommand())
            {
                comando.CommandText = "Select * from grado";
                var Reader = comando.ExecuteReader();
                while (Reader.Read())
                {
                    Grado grado = new Grado();
                    grado = Mapear(Reader);
                    grados.Add(grado);

                }
            }
            return grados;
        }

        public Grado Mapear(SqlDataReader reader)
        {
            Grado grado = new Grado();
            grado.idGrado = Convert.ToInt32(reader["idGrado"]);
            grado.nombre = (string)reader["nombre"];
            return grado;
        }
    }
}

