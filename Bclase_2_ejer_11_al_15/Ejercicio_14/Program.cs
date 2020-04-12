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

            int opcion;
            double numeroUno;
            double numeroDos;
            string seguir = "s";

            do
            {
                Console.Clear();
                Console.WriteLine("1. Calcular area de un cuadrado");
                Console.WriteLine("2. Calcular area de un triangulo");
                Console.WriteLine("3. Calcular area de un circulo");
                while (!Int32.TryParse(Console.ReadLine(), out opcion) || opcion > 3 || opcion < 1)
                {
                    Console.WriteLine("Ingrese una opcion valida");
                }
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese lado del cuadrado :");
                        while (!double.TryParse(Console.ReadLine(), out numeroUno))
                        {
                            Console.WriteLine("Ingrese un valor valido");
                        }
                        Console.WriteLine($"El area del cuadrado es: {CalculoDeArea.CalcularCuadrado(numeroUno)}");
                        break;
                    case 2:
                        Console.WriteLine("Ingrese base del triangulo :");
                        while (!double.TryParse(Console.ReadLine(), out numeroUno))
                        {
                            Console.WriteLine("Ingrese un valor valido");
                        }
                        Console.WriteLine("Ingrese altura del triangulo :");
                        while (!double.TryParse(Console.ReadLine(), out numeroDos))
                        {
                            Console.WriteLine("Ingrese un valor valido");
                        }
                        Console.WriteLine($"El area del triangulo es: {CalculoDeArea.CalcularTriangulo(numeroUno,numeroDos)}");
                        break;
                    case 3:
                        Console.WriteLine("Ingrese radio del circulo :");
                        while (!double.TryParse(Console.ReadLine(), out numeroUno))
                        {
                            Console.WriteLine("Ingrese un valor valido");
                        }
                        Console.WriteLine($"El area del circulo es: {CalculoDeArea.CalcularCirculo(numeroUno)}");
                        break;
                }
                Console.WriteLine("Presione s para seguir");
            } while (Console.ReadKey().KeyChar == 's');


           
        }
    }
}
