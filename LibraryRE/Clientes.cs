using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexionInterface;

namespace LibraryRE
{
    public class Clientes
    {
        AccesoMySql mysql = new AccesoMySql();
        public bool Conexion()
        {
           bool conex = mysql.AccesoMysql("localhost", "root", "usbw", "mibasededatos","3307");
            //bool conex = mysql.AccesoMysql("localhost", "root", "usbw", "mibasededatos");
            return conex;
        }
        string nombre;
        string apellido;
        string direccion;
        string telefono;
        string email;
        string CURP;

        public bool addClient()
        {
  
            return mysql.Agregar("clientes", "nombre,apellido,direccion,telefono,email,CURP", "'" + nombre + "','" + apellido + "','" + direccion + "','" + telefono + "','" + email + "','" + CURP1 + "'");

        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }


        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string CURP1
        {
            get
            {
                return CURP;
            }

            set
            {
                CURP = value;
            }
        }
    }
}
