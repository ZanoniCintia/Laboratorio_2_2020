using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia competencia1 = new Competencia(3,14);
            
            AutoF1 auto1 = new AutoF1("chevrolet",3);
            AutoF1 auto2 = new AutoF1("fiat", 4);
            AutoF1 auto3 = new AutoF1("Ford", 2);
            AutoF1 auto4 = new AutoF1("Ford", 1);
            AutoF1 auto5 = new AutoF1("Fiat", 5);
            AutoF1 auto6 = new AutoF1("Fiat", 6);


            if (competencia1 + auto1)
            {
                Console.WriteLine($"Se agregó ");
            }
            else
            {
                Console.WriteLine($"No se pudo agregar");
            }
            if (competencia1 + auto2)
            {
                Console.WriteLine($"Se agregó ");
            }
            else
            {
                Console.WriteLine($"No se pudo agregar");
            }
            if (competencia1 + auto3)
            {
                Console.WriteLine($"Se agregó ");
            }
            else
            {
                Console.WriteLine($"No se pudo agregar");
            }
            if (competencia1 - auto2)
            {
                Console.WriteLine($"Se elimino \n ");
            }
            else
            {
                Console.WriteLine("no se pudo \n");
            }

            Console.WriteLine(competencia1.MostrarDatos());
            Console.ReadKey();


        }
    }
}
