using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cpu:Producto
    {
        private int cantidadDeCooler;
        public Cpu(int id, float precio, string marca,int cantidadDeCooler, ETipo tipo, string combo,int stock) : base(id, precio, marca,tipo,combo,stock)
        {
            this.cantidadDeCooler = cantidadDeCooler;
        }
        /// <summary>
        /// sobreescritura del metodo mostrar que llama al metodo base y retorna un string con los datos del cpu
        /// </summary>
        /// <returns>retorna los datos del cpu</returns>
        public override string mostrar()
        {

            StringBuilder sb = new StringBuilder();


            sb.AppendLine(base.mostrar());

            
            sb.AppendLine($"cantidad de coolers: {this.cantidadDeCooler}");
            


            return sb.ToString();

        }
        /// <summary>
        /// sobreescritura del metodo toString que llama al metodo mostrar
        /// </summary>
        /// <returns>retorna los datos del cpu</returns>
        public override string ToString()
        {
            return this.mostrar();
        }
    }
}
