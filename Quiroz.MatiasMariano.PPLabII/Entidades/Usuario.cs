using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        private int id;
        private string nombre;
        private string apellido;
        private string email;
        private string clave;
        private bool admin;


        public Usuario(int id, string nombre, string apellido, string email, string clave, bool admin)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.clave = clave;
            this.admin = admin;

        }

        public Usuario(int id, string nombre, string apellido, string email, string clave) : this(id, nombre, apellido, email, clave, false)
        {


        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }

        }

        public bool Admin
        {
            get
            {
                return this.admin;
            }

        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }


        }
        /// <summary>
        /// recorre la lista de usuarios para validar que la clave y el email sean correctos
        /// </summary>
        /// <param name="electronica">contiene la lista de usuarios</param>
        /// <param name="email">email a corroborar</param>
        /// <param name="clave">clave a corroborar</param>
        /// <returns>retorna true si la clave y email son correctas caso contrario retorna false</returns>
        public static bool ValidarUsuario(Usuario electronica, string email, string clave)
        {
            if (electronica.email == email && electronica.clave == clave)
            {
                return true;

            }


            return false;
        }
        /// <summary>
        /// muestra los datos del usuario
        /// </summary>
        /// <returns>retorna un string con los datos del usuario</returns>
        public string mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre : {Nombre}");
            sb.AppendLine($"Apellido : {Apellido}");

            return sb.ToString();

        }
        /// <summary>
        /// sobrecarga del toString llama al metodo mostrar
        /// </summary>
        /// <returns>retorna un string con los datos del usuario</returns>
        public override string ToString()
        {
            return this.mostrar();
        }
    }
}
