using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    public class Conversor
    {
        public static string DecimalBinario(int numero)
        {
            string resultado = "";
            do
            {
                resultado = (numero % 2) + resultado;
                numero = numero / 2;
            } while (numero > 0);

            return resultado;
        }

        public static int BinarioDecimal(string numero)
        {
            string cadena = "Numero invalido";
            for (int i = 0; i < numero.Length; i++)
            {
                if (numero[i] != '0' && numero[i] != '1')
                {
                    return Convert.ToInt32(cadena);
                }
            }
            return Convert.ToInt32(numero, 2);

        }
    }
}
