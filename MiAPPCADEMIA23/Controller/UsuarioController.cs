using MiAPPCADEMIA23.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiAPPCADEMIA23.Controller
{
    public class UsuarioController
    {
        private List<Usuario> usuarios { get; set; }

        public UsuarioController()
        {
            this.usuarios = new List<Usuario>();    
        }

        public List<Usuario> GetUsuarios() {

            usuarios.Add(new Usuario("root", "1234"));
            usuarios.Add(new Usuario("profe", "1234"));
            usuarios.Add(new Usuario("invitado", "0000"));
            return this.usuarios;   
        }
    }
}
