using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Usuario
    {
        private String nombre;
        private String apellido;
        private String email;

        public Usuario(string nombre, string apellido, string email)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
        }
    }
}
