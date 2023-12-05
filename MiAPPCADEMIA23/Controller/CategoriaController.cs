using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


using MiAPPCADEMIA23.Model; 
namespace MiAPPCADEMIA23.Controller
{
    public class CategoriaController
    {
        List<Categoria> categorias {get; set;}
        //Cargar Categorias
        public CategoriaController()
        {
            categorias = new List<Categoria>();
        }
        public List<Categoria>  getCategorias()
        {
            Categoria benjamin = new Categoria(((int)Categoria.Categorias.Benjamin), "Benjamin"); 
            categorias.Add(benjamin);
            Categoria cadete = new Categoria(((int)Categoria.Categorias.Cadete), "Cadete"); 
            categorias.Add(cadete);
            Categoria juvenil = new Categoria(((int)Categoria.Categorias.Juvenil), "Juvenil"); 
            categorias.Add(juvenil);
            Categoria senior = new Categoria(((int)Categoria.Categorias.Senior), "Senior"); 
            categorias.Add(senior);
            return categorias; 
        }

    }
}
