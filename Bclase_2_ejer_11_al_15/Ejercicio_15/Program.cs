using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            double numeroUno;
            double numeroDos;
            string operacion;

            Console.Title = "Ejercicio_15";
            Console.WriteLine("CALCULADORA");
            Console.WriteLine("Ingrese un numero: ");
            numeroUno = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese operacion(+,-,*,/:)");
            operacion = Console.ReadLine();
            Console.WriteLine("Ingrese un numero: ");
            numeroDos = Double.Parse(Console.ReadLine());

            Console.WriteLine($"Resultado: {Calculadora.Calcular(numeroUno, numeroDos, operacion)}");
            Console.ReadKey();
        }
    }
}
