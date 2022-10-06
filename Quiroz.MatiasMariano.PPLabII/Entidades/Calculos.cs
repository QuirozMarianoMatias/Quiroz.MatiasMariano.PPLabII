using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{   
    public static class Calculos
    {
        /// <summary>
        /// la funcion agrega un 10% de aumento al float recibido por parametros y retorna el valor total
        /// </summary>
        /// <param name="precio">float con el valor a agregar un 10%</param>
        /// <returns>devuelve el valor total con el aumento aplicado</returns>
        public static float AplicarAumento(float precio)
        {
            float resultado;

            resultado = precio + (precio * 10 / 100);

            return resultado;
        }
    }
}
