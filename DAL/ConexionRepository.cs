using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DAL
{
    public class ConexionRepository
    {

        public static string cadena = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        
    }
}
