﻿using System;
using System.Collections.Generic;
using System.Text;



namespace Entidades
{
    public class Electronica
    {
        
        private static float capital;
        private List<Producto> productos;
        private List<Producto> ventas;
        private List<Usuario> usuarios;
        private static int cantidadDeVentas;


        static Electronica()
        {
            Electronica.capital = 0;
            cantidadDeVentas = 0;
        }

        public Electronica()
        {
            this.productos = new List<Producto>();
            this.usuarios = new List<Usuario>();
            this.ventas = new List<Producto>();

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

        public List<Producto> Ventas
        {

            get
            {
                return this.ventas;
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

        public int CantidadDeVentas
        {
            get
            {
                return Electronica.cantidadDeVentas;
            }
            set
            {
                if (value > 0)
                {
                    Electronica.cantidadDeVentas = value;
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

        
        /// <summary>
        /// metodo vender producto devuel verdadero si pudo realizar la venta si existe stock y el dinero del cliente alcanza
        /// </summary>
        /// <param name="electronica">electronica para buscar que existe el elemento en la lista</param>
        /// <param name="producto">elemento a vender</param>
        /// <param name="dineroDelCliente">pago del cliente</param>
        /// <param name="metodoDePago">metodo de pago que escogio el cliente</param>
        /// <returns>retorna verdadero si se pudo realizar la venta caso contrario devuelve falso</returns>
        public bool VenderProducto(Electronica electronica, Producto producto,float dineroDelCliente,string metodoDePago)
        {
            bool ventaCorrecta = false;
            if(electronica == producto && producto.Stock >0)
            {
                if(metodoDePago != "Credito")
                {

                    if(dineroDelCliente >= producto.Precio)
                    {
                        electronica.ventas.Add(producto);
                        producto.VentasPorCombo++;
                        Electronica.capital += producto.Precio;
                        producto.Stock--;
                        Electronica.cantidadDeVentas++;
                        ventaCorrecta = true;
                    }
                    
                  
                }
                else
                {
                    if (dineroDelCliente >= Calculos.AplicarAumento(producto.Precio))
                    {
                        electronica.ventas.Add(producto);
                        producto.VentasPorCombo++;
                        Electronica.capital += Calculos.AplicarAumento(producto.Precio);
                        producto.Stock--;
                        Electronica.cantidadDeVentas++;
                        ventaCorrecta = true;

                    }


                }    

              
            }

            return ventaCorrecta;

        }
        /// <summary>
        /// metodo que filtrar por combo y devuelve una lista con los combos filtrados
        /// </summary>
        /// <param name="electronica">electronica contiene la lista para buscar los productos</param>
        /// <param name="combo">combo por el cual filtrar</param>
        /// <returns>retorna una lista de productos filtradas</returns>
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
        /// <summary>
        /// buscar por id sirve para buscar un producto en particular
        /// </summary>
        /// <param name="electronica">contiene la lista de productos</param>
        /// <param name="Id">id para buscar el elemento</param>
        /// <returns>devuelve el elemento encontrado</returns>
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

        public Producto BuscarProductoMasVendido(Electronica electronica)
        {
            Producto producto = null;
            bool flag = true;
            int mayor= int.MinValue;

            foreach (Producto item in electronica.ventas)
            {
                

               foreach (Producto item2  in this.MostrarPorCombo(electronica, item.Combo))
               {
                    if(flag)
                    {
                        producto = item;
                        mayor += item2.VentasPorCombo;
                    }
                    else
                    {
                        if(item.VentasPorCombo > mayor )
                        {
                            producto = item;
                        }    
                    }
         

               }


            }

            return producto;
        }

        public float PromedioPorTag(Electronica electronica,string combo)
        {
            int ventas = 0;
            int contador = 0;
            float promedio;

            
            foreach (Producto producto in electronica.Productos)
            {
                if (producto.Combo == combo)
                {
                    ventas += producto.VentasPorCombo;
                    contador++;
                }

            }

            promedio = (float)ventas / contador;

            return promedio;
        }





    }
}
