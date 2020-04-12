using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura;
            string cadena = "*";

            Console.WriteLine("Ingrese altura de la piramide: ");
            altura = Convert.ToInt32(Console.ReadLine());

            if (altura > 0)
            {
                Console.WriteLine(cadena);
                for (int i = 0; i < altura; i++)
                {
                    cadena = cadena + "*";
                    Console.WriteLine(cadena);
                }
            }

            Console.ReadKey();
        }
    }
}
