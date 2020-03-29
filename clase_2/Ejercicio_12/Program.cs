using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 12";
            int numero;
            int acumulador = 0;
            do
            {
                Console.WriteLine("Ingrese numeros enteros, presione 's' para continuar y 'n' para terminar");
                Console.WriteLine("Numero: ");
                Int32.TryParse(Console.ReadLine(), out numero);
                Console.WriteLine("quiere continuar? s/n");
                acumulador += numero;
            } while (ValidarRespuesta.ValidaS_N(char.Parse(Console.ReadLine())));

            Console.WriteLine($"La suma total de los numeros es {acumulador}");
            Console.ReadKey();
        }
    }
}
