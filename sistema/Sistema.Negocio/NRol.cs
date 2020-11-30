using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Datos;
using System.Data;

namespace Sistema.Negocio
{
    public   class NRol
    {
        public static DataTable Listar()
        {
            DRol Datos = new DRol();
            return Datos.Listar();
        }
    }
}
