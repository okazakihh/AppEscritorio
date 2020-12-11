using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Security.Cryptography;

namespace Sistema.Datos
{
    public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private bool seguridad;
        private static Conexion Con = null;

        private Conexion()
        {
            this.Base = "dbsistemaprod ";
            this.Servidor = "DESKTOP-J5AN5ML\\PACHO";
            this.Usuario = "pacho";
            this.Clave = "pacho29";
            this.seguridad = true;

        }

        public  SqlConnection crearConexion()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = "Server=" + this.Servidor + "; Database=" + this.Base + ";";
                if(this.seguridad)
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "Integrated security = SSPI";                   
                }
                else
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "User Id =" + this.Usuario + ";Password =" + this.Clave;                               
                }
            }
            catch(Exception ex)
            {
                Cadena = null;
                throw ex;

            }
            return Cadena;
            
        }
        public static Conexion getInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();

            }
            return Con;
        }
    
    }

}
