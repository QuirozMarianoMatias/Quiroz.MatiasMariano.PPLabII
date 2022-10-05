using System;
using System.Collections.Generic;
using System.Text;



namespace Entidades
{
    public class Electronica
    {
        
        private static float capital;
        private List<Producto> productos;
        private List<Usuario> usuarios;


        static Electronica()
        {
            Electronica.capital = 0;
        }

        public Electronica()
        {
            this.productos = new List<Producto>();
            this.usuarios = new List<Usuario>();

        }

        
        public List<Producto> Productos
        {

            get
            {
                return this.productos;
            }
        }

        public List<Usuario> Usuarios
        {

            get
            {
                return this.usuarios;
            }
        }




        public float Capital
        {
            get
            {
                return Electronica.capital;
            }
            set
            {
                if(value > 0)
                {
                    Electronica.capital = value;
                }
            }


        }


      
      

        public static bool operator ==(Electronica electronica, Producto producto)
        {
            foreach (Producto item in electronica.productos)
            {
                if(item == producto)
                {
                    return true;
                }

            }
            return false;
        }

        public static bool operator !=(Electronica electronica, Producto producto)
        {

            return !(electronica == producto);
        }

        public static bool operator ==(Electronica electronica, Usuario usuario)
        {
            foreach (Usuario item in electronica.usuarios)
            {
                if (item == usuario)
                {
                    return true;
                }

            }
            return false;
        }


        public static bool operator !=(Electronica electronica, Usuario usuario)
        {

            return !(electronica == usuario);
        }



        public static Electronica operator +(Electronica electronica,Producto producto)
        {
            


            if(producto != null && producto.Stock > 0 && electronica != producto)
            {
                electronica.productos.Add(producto);

            }


            return electronica;

        }

        public static Electronica operator +(Electronica electronica, Usuario usuario)
        {



            if (usuario != null && electronica != usuario)
            {
                electronica.usuarios.Add(usuario);

            }


            return electronica;

        }

        public static Electronica operator -(Electronica electronica, Producto producto)
        {



            if (electronica == producto)
            {
                electronica.productos.Remove(producto);
            }


            return electronica;

        }

        public static Electronica operator -(Electronica electronica, Usuario usuario)
        {



            if (usuario != null)
            {
                electronica.usuarios.Remove(usuario);

            }


            return electronica;

        }

        

        public bool VenderProducto(Electronica electronica, Producto producto,float dineroDelCliente,string metodoDePago)
        {
            bool ventaCorrecta = false;
            if(electronica == producto && producto.Stock >0)
            {
                if(metodoDePago != "Credito")
                {

                    if(dineroDelCliente >= producto.Precio)
                    {
                        Electronica.capital += producto.Precio;
                        producto.Stock--;
                        ventaCorrecta = true;
                    }
                    
                  
                }
                else
                {
                    if (dineroDelCliente >= Calculos.AplicarAumento(producto.Precio))
                    {
                        Electronica.capital += Calculos.AplicarAumento(producto.Precio);
                        producto.Stock--;
                        ventaCorrecta = true;
                    }


                }    

              
            }

            return ventaCorrecta;

        }

        public List<Producto> MostrarPorCombo(Electronica electronica, string combo)
        {
            List<Producto> productos = new List<Producto> ();
            foreach (Producto producto in electronica.Productos)
            {
                if(producto.Combo == combo)
                {
                    productos.Add(producto);
                }

            }


            return productos;


        }

        public List<Producto> BuscarPorId(Electronica electronica, int Id)
        {
            List<Producto> productos = new List<Producto>();
            foreach (Producto producto in electronica.Productos)
            {
                if (producto.Id == Id)
                {
                    productos.Add(producto);
                }

            }


            return productos;


        }




    }
}
