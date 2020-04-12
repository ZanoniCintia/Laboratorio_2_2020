using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 3";
            int numero;
            bool primo;
            Console.WriteLine("Ingrese un numero");
            numero = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= numero; i++)
            {
                primo = true;
                for (int j = i - 1; j > 1; j--)
                {
                   if (i % j == 0)
                   {
                       primo = false;
                       break;
                   }
                }
                if (primo)
                {
                    Console.WriteLine($"primo :{i}");
                }
            }
           
                Console.ReadKey();
            }
        }
}
