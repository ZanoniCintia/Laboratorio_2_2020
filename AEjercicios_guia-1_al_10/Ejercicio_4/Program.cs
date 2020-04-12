using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 4";
            int numeros=0;
            int divisor;
            //Itera hasta encontrar 4 numeros.
            for (int i = 1; numeros < 4; i++)
            {
                //Inicializa el acumulador de divisores en 0.
                divisor = 0;
                //Itera todos los numeros positivos menores al indice
                for(int j = i - 1; j>0 ; j--)
                {   
                    //se fija si es divisor de si mismo
                    if (i % j == 0)
                    {   
                        //acumula los divisores
                        divisor += j;
                    }
                }
                //Prueba si los divisores acumulados es igual al numero.
                if (divisor==i)
                {
                    //Imprime el numero y aumenta el contador de numeros encontrados.
                    Console.WriteLine($"Numero perfecto: {i}");
                    numeros++;
                }
            }
            Console.ReadKey();
        }
    }
}
