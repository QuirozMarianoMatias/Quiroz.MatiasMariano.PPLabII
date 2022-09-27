using System;
using System.Text;

namespace Entidades
{
    public abstract class Electronica
    {
        protected int id;
        protected string nombre;
        protected string apellido;
        private string email;
        private string clave;
        protected int cantidadDeVentas;

        protected Electronica(int id, string nombre, string apellido, string email, string clave, int cantidadDeVentas)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.clave = clave;
            this.cantidadDeVentas = cantidadDeVentas;
        }

        protected Electronica(int id, string nombre, string apellido, string email, string clave):this(id,nombre,apellido,email,clave,0)
        {

        }





        public string Nombre
        {
            get
            {
                return this.nombre;
            }

        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }

        }

        public int CantidadDeVentas
        {
            get
            {
                return this.cantidadDeVentas;
            }
            set
            {
                if(value >=0)
                {
                    this.cantidadDeVentas = value;
                }

            }

        }



        public bool ValidarUsuario(Electronica persona, string email, string clave)
        {
            if(persona.clave == clave && persona.email == email)
            {
                return true;
            }

             
            return false;
        }

        public abstract string mostrar();
        


    }
}
