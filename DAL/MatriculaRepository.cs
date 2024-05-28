using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class MatriculaRepository
    {
        SqlConnection connection;
        List<Matricula> matriculas;

        public MatriculaRepository(ConnectionManager Connection)
        {
            connection = Connection.connection;
            matriculas = new List<Matricula>();
        }

        public void Registrar(Matricula matricula)
        {
            using (var comando = connection.CreateCommand())
            {
                comando.CommandText = " Insert  Into matricula (idGrado,idEstudiante)" +
                   "Values(@idGrado,@idEstudiante)";
                comando.Parameters.AddWithValue("@idMatricula", matricula.IdMatricula);
                comando.Parameters.AddWithValue("@idGrado", matricula.GradoEscolar);
                comando.Parameters.AddWithValue("@idEstudiante", matricula.IdEstudiante);
                comando.ExecuteNonQuery();
            }
        }
        public List<Matricula> Consultar()
        {
            using (var comando = connection.CreateCommand())
            {
                comando.CommandText = "select m.idMatricula,e.idEstudiante, e.nombres,e.apellidos,g.nombre  from matricula m join estudiante e on m.idEstudiante = e.idEstudiante  join grado g on m.idGrado = g.idGrado";
                var Reader = comando.ExecuteReader();
                while (Reader.Read())
                {
                    Matricula matricula = new Matricula();
                    matricula = Mapear(Reader);
                    matriculas.Add(matricula);

                }
            }
            return matriculas;
        }

        public Matricula Mapear(SqlDataReader reader)
        {
            Matricula matricula = new Matricula();
            matricula.IdMatricula = Convert.ToInt32(reader["idMatricula"]);
            matricula.GradoEscolar = (string)reader["nombre"];
            matricula.IdEstudiante = (string)reader["idEstudiante"];
            matricula.Nombres = (string)reader["nombres"];
            matricula.Apellidos = (string)reader["apellidos"];
            return matricula;
        }
        public List<Matricula> ListarTipo(string tipo)
        {
            matriculas = Consultar();
            return matriculas.Where(p => p.GradoEscolar.Equals(tipo)).ToList();
        }
    }
    
        
}
