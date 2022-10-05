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

        public override string mostrar()
        {

            StringBuilder sb = new StringBuilder();


            sb.AppendLine(base.mostrar());

            
            sb.AppendLine($"cantidad de coolers: {this.cantidadDeCooler}");
            


            return sb.ToString();

        }

        public override string ToString()
        {
            return this.mostrar();
        }
    }
}
