using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculos
    {
        public static float AplicarAumento(float precio)
        {
            float resultado;

            resultado = precio + (precio * 10 / 100);

            return resultado;
        }
    }
}
