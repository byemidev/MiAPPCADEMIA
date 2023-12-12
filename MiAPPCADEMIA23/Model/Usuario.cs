using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiAPPCADEMIA23.Model
{
    [Serializable]
    public class Usuario
    {
        string id { get; set; }
        string clave { get; set; }
        bool estado { get; set; }

        //devuelve el estado
        public bool  getEstado() { 
            return this.estado;
        }
        //permite a modificar el valor de estado desde una instancia de esta clase
        public void setEstado(bool estado) {
            this.estado = estado;
        }        
        public string getId() { 
            return this.id;
        }

        public string getClave() { 
            return this.clave;
        }

        public Usuario() { 
        //constructor vacio
        }

        public Usuario(string id, string clave) {
            this.id = id;
            this.clave = clave;
            this.estado = true;//cuando creo un usuario sera siempre true , el estado lo cambio cuando alguien se da de baja para no cargarlo del json 
        }
    }
}
