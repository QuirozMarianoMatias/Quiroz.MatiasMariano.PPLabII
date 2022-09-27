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
        public Cpu(int id, float precio, string marca, bool conCable,int cantidadDeCooler) : base(id, precio, marca)
        {
            this.cantidadDeCooler = cantidadDeCooler;
        }

       

    }
}
