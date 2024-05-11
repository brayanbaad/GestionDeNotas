using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace BLL
{
    public class UsuarioService
    {
        private UsuarioRepository usuarioRepository = new UsuarioRepository();

        public List<Usuario> Listar()
        {
            return usuarioRepository.Listar();
        }





    }
}
