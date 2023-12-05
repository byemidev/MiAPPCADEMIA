using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiAPPCADEMIA23.Model
{
    public class Categoria
    {
        int cod { get; set; }
        string nombre { get; set; }



        public Categoria(int  cod,  string nombre){
            this.cod = cod;
            this.nombre = nombre;   
        }
        
        public Categoria() { }  
        
        
        public enum Categorias : int 
        {
            Benjamin = 1, 
            Cadete = 2,
            Juvenil = 3, 
            Senior = 4
        }

        public  string ToString()
        {
            return ("La categoria " + this.nombre + " con identificador " + this.cod); 
        }
    }
}
