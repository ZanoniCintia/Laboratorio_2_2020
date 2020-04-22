using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 31";
            Cliente cliente1 = new Cliente("Bryanna",23);
            Cliente cliente2 = new Cliente("Joe", 13);
            Cliente cliente3 = new Cliente("Margot", 23);
            Cliente cliente4 = new Cliente("Sol", 13);
            Cliente cliente5 = new Cliente("Cintia", 18);

            Negocio negocio1 = new Negocio("EL Negocio N°1");

            if(negocio1 + cliente1)
            {
                Console.WriteLine("Agregado cliente1");
            }
            else { Console.WriteLine("No gregado"); }
            if(negocio1 + cliente2)
            {
                Console.WriteLine("Agregado cliente2");
            }else { Console.WriteLine("No gregado"); }

            if (negocio1 + cliente3)
            {
                Console.WriteLine("Agregado cliente3");
            }
            else { Console.WriteLine("No gregado"); }

            if (negocio1 + cliente4)
            {
                Console.WriteLine("Agregado cliente4");
            }
            else { Console.WriteLine("No gregado"); }

            if (negocio1 + cliente5)
            {
                Console.WriteLine("Agregado cliente5");
            }
            else { Console.WriteLine("No gregado"); }

            Console.ReadLine();

        }
    }
}
