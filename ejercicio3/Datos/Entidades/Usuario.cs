using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Usuario
    {
        public String Codigo { get; set; }

        public String Nombre { get; set; }

        public String Tipo_usuario { get; set; }

        public String Clave { get; set; }

        public bool EstaActivo { get; set; }

        public Usuario()
        {
        }

        public Usuario(string codigo, string nombre, string tipo_usuario, string clave, bool estaActivo)
        {
            Codigo = codigo;
            Nombre = nombre;
            Tipo_usuario = tipo_usuario;
            Clave = clave;
            EstaActivo = estaActivo;
            
        }


    }
}
