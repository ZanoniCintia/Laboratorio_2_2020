using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 17";
            
            Boligrafo azul = new Boligrafo(ConsoleColor.Blue,100);
            Boligrafo rojo = new Boligrafo(ConsoleColor.Red, 50);
            string estrella = "";
            Console.WriteLine($"Ingrese gasto de tinta: ");
            string cadena = ( Console.ReadLine());
            Console.WriteLine(azul.Pintar(short.Parse(cadena), out estrella ));
            Console.WriteLine(rojo.Pintar(short.Parse(cadena), out estrella));
            Console.ReadKey();
        }
    }
}
