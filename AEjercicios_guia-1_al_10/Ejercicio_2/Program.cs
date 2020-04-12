using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title="Ejercicio 2";
           int numero;

            Console.WriteLine("Ingrese un numero");
            numero = Convert.ToInt32(Console.ReadLine());
            while (numero < 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
               
            }

            Console.WriteLine("Cuadrado: {0}", Math.Pow(numero, 2));
            Console.WriteLine("Cubo: {0}", Math.Pow(numero, 3));

            Console.ReadKey();
        }
    }
}
