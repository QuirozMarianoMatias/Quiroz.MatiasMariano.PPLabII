using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum ETipo
    {
        Procesador,
        PlacaDeVideo,
        Teclado,
        Mouse,
        Auriculares,
    }
    public abstract class Producto
    {
        protected int id;
        protected float precio;
        protected ETipo tipo;
        protected string combo;
        protected int stock;
        protected string marca;

        protected Producto(int id, float precio, string marca,ETipo tipo, string combo,int stock)
        {
            this.id = id;
            this.precio = precio;
            this.marca = marca;
            this.tipo = tipo;
            this.combo = combo;
            this.stock = stock;
        }


        public float Precio
        {
            get
            { 
                return this.precio; 
            }
            set 
            {
                if(value > 0)
                {
                    this.precio = value;
                }
            }
        }

        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                if(value > 0)
                {
                    this.stock = value;
                }
                else
                {
                    this.stock = 0;
                }
            }
        }

        public string Tipo
        {
            get
            {
                return Enum.GetName(typeof(ETipo), this.tipo);
            }
        }
        public string Marca
        {
            get
            {
                return this.marca;
            }
          
        }

        public string Combo
        {
            get
            {
                return this.combo;
            }
            set
            {
                if(value != null )
                {
                    this.combo = "sin promocion";
                }
                else
                {
                    this.combo = value;
                }
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }

        }

      
        /// <summary>
        /// metodo mostrar muestra los datos del producto
        /// </summary>
        /// <returns>retorna los datos del producto</returns>
        public virtual string mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"id : {this.Id}");
            sb.AppendLine($"Marca : {this.Marca}");
            sb.AppendLine($"tipo : {this.Tipo}");
            sb.AppendLine($"Precio : {this.Precio}");
            sb.AppendLine($"Combo : {this.Combo}");
            sb.AppendLine($"Stock : {this.Stock}");


            return sb.ToString();


        }
        /// <summary>
        /// sobreescritura del metodo toString que llama al metodo mostrar
        /// </summary>
        /// <returns>retorna los datos del producto</returns>
        public override string ToString()
       {
            return this.mostrar();
       }


    }
}
