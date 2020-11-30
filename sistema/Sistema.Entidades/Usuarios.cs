using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public  class Usuarios
    {
        public int IdUsuario { set; get; }
        public int IdRol { set; get; }
        public string Nombre { set; get; }
        public string TipoDocumento { set; get; }
        public string NumeroDocumento { set; get; }
        public string Direccion { set; get; }
        public string Telefono { set; get; }
        public string Email { set; get; }
        public string Clave { set; get; }
        public bool Estado { set; get; }

    }
}
