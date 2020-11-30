using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Datos;
using System.Data;
using Sistema.Entidades;

namespace Sistema.Negocio
{
    public  class NUsuario
    {
        public static DataTable Listar()
        {
            DUsuario Datos = new DUsuario();
            return Datos.Listar();
        }

        public static DataTable Buscar(string valor)
        {
            DUsuario Datos = new DUsuario();
            return Datos.Buscar(valor);
        }
        public static DataTable Login(string Email, string Clave)
        {
            DUsuario Datos = new DUsuario();
            return Datos.Login(Email, Clave);
        }

        public static string Insertar(int IdRol, string Nombre,string TipoDocumento, string NumDocumento, string Direccion, string Telefono,string Email,string Clave)
        {
            DUsuario Datos = new DUsuario();
            string Existe = Datos.Existe(Email);
            if (Existe.Equals("1"))
            {
                return "El email de usuario ya existe en la base de datos";
            }
            else
            {
                Usuarios obj = new Usuarios();
                obj.IdRol = IdRol;
                obj.Nombre = Nombre;
                obj.TipoDocumento = TipoDocumento;
                obj.NumeroDocumento = NumDocumento;
                obj.Direccion = Direccion;
                obj.Telefono = Telefono;
                obj.Email = Email;
                obj.Clave = Clave;
                return Datos.Insertar(obj);
            }
        }

        public static string Actualizar(int Id, int IdRol, string Nombre, string TipoDocumento, string NumDocumento, string Direccion, string Telefono,string EmailAnt, string Email, string Clave)
        {
            DUsuario Datos = new DUsuario();
            Usuarios obj = new Usuarios();

            if (EmailAnt.Equals(Email))
            {
                obj.IdUsuario = Id;
                obj.IdRol = IdRol;
                obj.Nombre = Nombre;
                obj.TipoDocumento = TipoDocumento;
                obj.NumeroDocumento = NumDocumento;
                obj.Direccion = Direccion;
                obj.Telefono = Telefono;
                obj.Email = Email;
                obj.Clave = Clave;
                return Datos.Actualizar(obj);
            }
            else
            {
                string Existe = Datos.Existe(Email);
                if (Existe.Equals("1"))
                {
                    return "El email de usuario ya existe en la base de datos";
                }
                else
                {
                    obj.IdUsuario = Id;
                    obj.IdRol = IdRol;
                    obj.Nombre = Nombre;
                    obj.TipoDocumento = TipoDocumento;
                    obj.NumeroDocumento = NumDocumento;
                    obj.Direccion = Direccion;
                    obj.Telefono = Telefono;
                    obj.Email = Email;
                    obj.Clave = Clave;
                    return Datos.Actualizar(obj);

                }
            }
        }
        public static string Eliminar(int Id)
        {
            DUsuario Datos = new DUsuario();
            return Datos.Eliminar(Id);
        }
        public static string Activar(int Id)
        {
            DUsuario Datos = new DUsuario();
            return Datos.Activar(Id);
        }

        public static string Desactivar(int Id)
        {
            DUsuario Datos = new DUsuario();
            return Datos.Desactivar(Id);
        }
    }
}
