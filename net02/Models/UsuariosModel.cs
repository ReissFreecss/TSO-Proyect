using net02.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net02.Models
{
    public class UsuariosModel
    {
        public string Usuario { get; set; } 
        public string Nombre { get; set; }
        public int Tipo { get; set; }   
        /*public UsuariosModel(string usuario, string clave)
        {
            Usuario = usuario;
            /* Normalizador no se ocupa*/
            /* Validator Aquí validemos*/
            /*llamada a un método de Context para obtener el usuario*/
          //  this. = AContext.Login(usuario, clave);
       // }
    }
}
