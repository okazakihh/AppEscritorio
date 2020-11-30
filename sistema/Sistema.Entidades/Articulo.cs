using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
   public  class Articulo
   {
        public int IdArticulo { set; get; }
        public int IdCategoria { set; get; }
        public string Codigo { set; get; }
        public string Nombre { set; get; }
        public decimal PrecioVenta { set; get; }
        public int Stock { set; get; }
        public string Descripcion { set; get; }
        public string Imagen { set; get; }
        public bool Estado { set; get; }

   }
}
