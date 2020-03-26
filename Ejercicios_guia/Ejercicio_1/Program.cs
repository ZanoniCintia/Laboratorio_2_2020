using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 1";
            int numero;
            int minimo = int.MaxValue;
            int maximo = int.MinValue;
            int suma=0;
            float promedio;
            int i = 0;
            string auxiliar;

            do
            {   
                Console.WriteLine("Ingrese un numero");
                auxiliar= Console.ReadLine();
                if(int.TryParse(auxiliar,out numero))
                {
                    if (numero > maximo)
                    {
                        maximo = numero;
                    }
                    else if (numero < minimo)
                    {
                        minimo = numero;
                    }
                }

                suma += numero;
                i++;

            } while(i < 5);

            promedio = suma / 5;
            Console.WriteLine($"El maximo es :{maximo} El minimo es :{minimo} La suma total es :{suma} El promedio es {promedio}");
            Console.ReadKey();
        }
    }
}
