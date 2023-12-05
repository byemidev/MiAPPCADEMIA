using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiAPPCADEMIA23.Model
{
    public class Usuario
    {
        string id { get; set; }
        string clave { get; set; }
        bool status { get; set; }


        public string getId() { 
            return this.id;
        }

        public string getClave() { 
            return this.clave;
        }
        public Usuario(string id, string clave) {
            this.id = id;
            this.clave = clave;
            this.status = true;//cuando creo un usuario sera siempre true , el estado lo cambio cuando alguien se da de baja para no cargarlo del json 
        }
    }
}
