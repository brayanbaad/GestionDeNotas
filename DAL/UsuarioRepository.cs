using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entity;

namespace DAL
{
    public class UsuarioRepository
    {
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();
            using (SqlConnection conexion = new SqlConnection(ConexionRepository.cadena))
            {
                try
                {
                    string query = "select * from Usuario";
                    SqlCommand cmd =  new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;
                    conexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Usuario()
                            {
                                Id = Convert.ToInt32(dr["id"]),
                                IdUsuario = dr["idUsuario"].ToString(),
                                Clave= dr["clave"].ToString(),
                                Rol = dr["rol"].ToString(),

                            }) ;
                        }
                    }

                }
                catch (Exception )
                {
                    lista = new List<Usuario>();
                   
                }
                
            }
            return lista;
        }
        

    }
}
