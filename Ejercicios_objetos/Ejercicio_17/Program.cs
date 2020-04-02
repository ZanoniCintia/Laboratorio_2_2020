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

            Boligrafo azul = new Boligrafo(100,ConsoleColor.Blue);
            Boligrafo rojo = new Boligrafo(50,ConsoleColor.Red);
            String dibujo;
            

            Console.WriteLine("Boligrafo azul: ");
            Console.WriteLine("Color: {0}", azul.GetTinta());
            Console.WriteLine("Nivel tinta: {0}", azul.GetTinta());
            Console.WriteLine("Pudo pintar: {0}", azul.Pintar(10, out dibujo));
            Console.WriteLine("Nivel tinta: {0}", azul.GetTinta());
            Console.WriteLine("Dibujo: {0}", dibujo);
            Console.WriteLine("Recargando tinta");
            Console.ReadKey();
            azul.Recargar();
            Console.WriteLine("Nivel tinta: {0}", azul.GetTinta());
            Console.ReadKey();

            Console.WriteLine();

            Console.WriteLine("Boligrafo rojo: ");
            Console.WriteLine("Color: {0}", rojo.GetTinta());
            Console.WriteLine("Nivel tinta: {0}", rojo.GetTinta());
            Console.WriteLine("Pudo pintar: {0}", rojo.Pintar(20, out dibujo));
            Console.WriteLine("Nivel tinta: {0}", rojo.GetTinta());
            Console.WriteLine("Dibujo: {0}", dibujo);
            Console.WriteLine("Recargando tinta");
            Console.ReadKey();
            rojo.Recargar();
            Console.WriteLine("Nivel tinta: {0}", rojo.GetTinta());
            Console.ReadKey();
        }
    }
}
