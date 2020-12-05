using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Sistema.Entidades
{
    public class Ingreso
    {
        public int IdIngreso { set; get; }
        public int IdProveedor { set; get; }
        public int  IdUsuario { set; get; }
        public string TipoComprobante { set; get; }
        public string SerieComprobante { set; get; }
        public string NumComprobante { set; get; }
        public DateTime Fecha { set; get; }
        public decimal Impuesto { set; get; }
        public decimal Total { set; get; }
        public string Estado { set; get; }
        public DataTable Detalles { set; get; }


    }
}
