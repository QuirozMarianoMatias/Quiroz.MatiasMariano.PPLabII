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


        /// <summary>
        /// sobreescritura del metodo mostrar que llama al metodo base y retorna un string con los datos del perifericos
        /// </summary>
        /// <returns>retorna los datos del perifericos</returns>
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
        /// <summary>
        /// sobreescritura del metodo toString que llama al metodo mostrar
        /// </summary>
        /// <returns>retorna los datos del perifericos</returns>
        public override string ToString()
        {
            return this.mostrar();
        }


    }
}
