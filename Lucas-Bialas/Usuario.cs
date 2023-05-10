using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucas_Bialas
{
    internal class Usuario
    {
        //atributos
        private int id;
        private string nombre;
        private string apellido;
        private string nombreUsuario;
        private string contrasena;
        private string mail;

        //constructor
        public Usuario(int id, string nombre,
                       string apellido,
                       string nombreUsuario,
                       string contrasena,
                       string mail)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.nombreUsuario = nombreUsuario;
            this.contrasena = contrasena;
            this.mail = mail;
        }

        //getters y setters
        public int GetId()
        {
            return this.id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public String GetNombre()
        {
            return this.nombre;
        }

        public void SetNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public String GetApellido()
        {
            return this.apellido;
        }

        public void SetApellido(String apellido)
        {
            this.apellido = apellido;
        }

        public String GetNombreUsuario()
        {
            return this.nombreUsuario;
        }

        public void SetNombreUsuario(String nombreUsuario)
        {
            this.nombreUsuario = nombreUsuario;
        }

        public String GetContrasena()
        {
            return this.contrasena;
        }

        public void SetContrasena(String contrasena)
        {
            this.contrasena = contrasena;
        }

        public String GetMail()
        {
            return this.mail;
        }

        public void SetMail(String mail)
        {
            this.mail = mail;
        }

    }
}

