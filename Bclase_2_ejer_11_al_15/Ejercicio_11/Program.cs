using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int maximo=int.MinValue;
            int minimo=int.MaxValue;
            int hasta = 0;
            int acumulador = 0;
            float promedio;

            Console.WriteLine($"Ingrese 10 numeros entre 100 y -100: ");
            do
            {
                Console.WriteLine($"Ingrese un numero : ");
                Int32.TryParse(Console.ReadLine(), out numero);
                if (Validacion.Validar(numero,-100,100))
                {
                    if (numero > maximo)
                    {
                        maximo = numero;

                    }
                    if (numero < minimo)
                    {
                        minimo = numero;
                    }
                    acumulador += numero;
                }
                else
                {
                    Console.WriteLine("Error, entre 100 y -100");
                }
                

                hasta++;
            } while (hasta < 10);
            promedio = acumulador / 10;
            Console.WriteLine($"El numero maximo es : {maximo}");
            Console.WriteLine($"El numero minimo es : {minimo}");
            Console.WriteLine($"El numero promedio es : {promedio}");
            Console.ReadKey();



        }
    }
}
