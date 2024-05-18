using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Docente
    {
        public int Id { get; set; }
        public string Identificacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string Especialidad { get; set; }
        public string Telefono { get; set; }
    }
}
