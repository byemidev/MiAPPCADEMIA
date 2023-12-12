using MiAPPCADEMIA23.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//IO
using System.IO;
using System.Xml;
//XML
using System.Xml.Serialization;
//bin
using System.Runtime.Serialization.Formatters.Binary;

namespace MiAPPCADEMIA23.Controller
{
    public class UsuarioController
    {
        private List<Usuario> usuarios { get; set; }

        public UsuarioController()
        {
            this.usuarios = new List<Usuario>();
        }
        //No hay una lista creada de usuarios s
        //#01- Crear una base de datos de usarios con XML se puede leer con BinaryReader & BinaryWriter para XML y JSON
        //System.Text.JSON o newton.Json de nuget 
    
    
    }
}
