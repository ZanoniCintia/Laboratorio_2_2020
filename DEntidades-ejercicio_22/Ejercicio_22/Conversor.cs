using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_22
{
    public class Conversor
    {
        public static string DecimalBinario(double numero)
        {
            string resultado = "";
            numero = Math.Abs(numero);
            do
            {
                resultado = (numero % 2) + resultado;
                numero = (int)numero / 2;


            } while (numero > 0);

            return resultado;
        }

        public static double BinarioDecimal(string numero)
        {
            char[] binario = numero.ToCharArray();
            Array.Reverse(binario);
            int dec = 0;
            int i;

            for (i = 0; i < binario.Length; i++)
            {
                if (binario[i] == '1')
                {
                    dec += (int)Math.Pow(2, i);
                }
            }
            return dec;

        }
    }

}
