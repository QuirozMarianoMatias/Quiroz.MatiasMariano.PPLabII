using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perifericos : Producto
    {
        private bool conCable;
        public Perifericos(int id, float precio, string marca,bool conCable,ETipo tipo,string combo,int stock):base(id,precio,marca,tipo,combo,stock)
        {
            this.conCable = conCable;
        }



        public override string mostrar()
        {
          
            StringBuilder sb = new StringBuilder();


            sb.AppendLine(base.mostrar());

            if (this.conCable)
            {
                sb.AppendLine("con cable: si");
            }
            else
            {
                sb.AppendLine("con cable: no");
            }
           


            return sb.ToString();

        }

        public override string ToString()
        {
            return this.mostrar();
        }


    }
}
