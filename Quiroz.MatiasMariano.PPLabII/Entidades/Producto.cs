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
        Auriculares
    }
    public abstract class Producto
    {
        protected int id;
        protected float precio;
        protected ETipo tipo;
        protected string marca;

        protected Producto(int id, float precio, string marca)
        {
            this.id = id;
            this.precio = precio;
            this.marca = marca;
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

        public string Marca
        {
            get
            {
                return this.marca;
            }
          
        }

        public int Id
        {
            get
            {
                return this.id;
            }

        }

        public virtual string mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"id :{Id}");
            sb.AppendLine($"id :{Marca}");
            sb.AppendLine($"tipo:{Enum.GetName(typeof(ETipo),tipo)}");
            sb.AppendLine($"id :{Precio}");


            return sb.ToString();


        }

        public override string ToString()
        {
            return mostrar();
        }


    }
}
