using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Sistema.Datos;
using Sistema.Entidades;

namespace Sistema.Negocio
{
    public  class NPersona
    {
       
        public static DataTable Listar()
        {
            DPersona Datos = new DPersona();
            return Datos.Listar();
        }
        public static DataTable ListarProveedores()
        {
            DPersona Datos = new DPersona();
            return Datos.ListarProveedores();
        }
        public static DataTable ListarClientes()
        {
            DPersona Datos = new DPersona();
            return Datos.ListarClientes();
        }

        public static DataTable Buscar(string valor)
        {
            DPersona Datos = new DPersona();
            return Datos.Buscar(valor);
        }
        public static DataTable BuscarProveedores(string valor)
        {
            DPersona Datos = new DPersona();
            return Datos.BuscarProveedores(valor);
        }
        public static DataTable BuscarClientes(string valor)
        {
            DPersona Datos = new DPersona();
            return Datos.BuscarClientes(valor);
        }
        public static string Insertar(string TipoPersona, string Nombre, string TipoDocumento, string NumDocumento, string Direccion, string Telefono, string Email)
        {
            DPersona Datos = new DPersona();
            string Existe = Datos.Existe(Nombre);
            if (Existe.Equals("1"))
            {
                return "Esta persona ya existe en la base de datos";
            }
            else
            {
                persona obj = new persona();
                obj.TipoPersona = TipoPersona;
                obj.Nombre = Nombre;
                obj.TipoDocumento = TipoDocumento;
                obj.NumDocumento = NumDocumento;
                obj.Direccion = Direccion;
                obj.Telefono = Telefono;
                obj.Email = Email;
                return Datos.Insertar(obj);
            }
        }

        public static string Actualizar(int Id, string TipoPersona, string NombreAnt, string Nombre, string TipoDocumento, string NumDocumento, string Direccion, string Telefono,  string Email)
        {
            DPersona Datos = new DPersona();
            persona obj = new persona();

            if (NombreAnt.Equals(Nombre))
            {
                obj.IdPersona = Id;
                obj.TipoPersona = TipoPersona;
                obj.Nombre = Nombre;
                obj.TipoDocumento = TipoDocumento;
                obj.NumDocumento = NumDocumento;
                obj.Direccion = Direccion;
                obj.Telefono = Telefono;
                obj.Email = Email;
                return Datos.Actualizar(obj);
            }
            else
            {
                string Existe = Datos.Existe(Nombre);
                if (Existe.Equals("1"))
                {
                    return "Esta persona ya existe en la base de datos";
                }
                else
                {
                    obj.IdPersona = Id;
                    obj.TipoPersona = TipoPersona;
                    obj.Nombre = Nombre;
                    obj.TipoDocumento = TipoDocumento;
                    obj.NumDocumento = NumDocumento;
                    obj.Direccion = Direccion;
                    obj.Telefono = Telefono;
                    obj.Email = Email;
                    return Datos.Actualizar(obj);

                }
            }
        }
        public static string Eliminar(int Id)
        {
            DPersona Datos = new DPersona();
            return Datos.Eliminar(Id);
        }
    }
}
