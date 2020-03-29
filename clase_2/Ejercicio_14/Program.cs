using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_14";

            double cuadrado;
            double basee;
            double altura;
            double radio;

            Console.WriteLine("Calculo de Areas");
            Console.WriteLine("Ingrese Lado del cuadrado :");
            cuadrado = Double.Parse(  Console.ReadLine());
            Console.WriteLine($"El area del cuadrado es : {CalculoDeArea.CalcularCuadrado(cuadrado)}");

            Console.WriteLine("Ingrese base del triangulo: ");
            basee = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese altura del triangulo: ");
            altura = Double.Parse(Console.ReadLine());
            Console.WriteLine($"El area del Triangulo es: {CalculoDeArea.CalcularTriangulo(basee,altura)}");

            Console.WriteLine("Ingrese radio del circulo :");
            radio = Double.Parse(Console.ReadLine());
            Console.WriteLine($"El area del circulo es: {CalculoDeArea.CalcularCirculo(radio)}");



            Console.ReadKey();
        }
    }
}
