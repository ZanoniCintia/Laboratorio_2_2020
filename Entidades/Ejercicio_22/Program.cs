using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_22
{
    class Program
    {
        static void Main(string[] args)
        {
            NumeroBinario bin = "1000";
            NumeroDecimal dec = 50;

            Console.WriteLine($"Conversion implicita: bin {bin.GetNumero()}, dec {dec.GetNumero()}");

            Console.WriteLine($"\nSuma entre ambos (en binario): {bin + dec}");
            Console.WriteLine($"\nSuma entre ambos: {dec + bin}");
            Console.WriteLine($"Resta entre ambos (en binario): {bin - dec}");
            Console.WriteLine($"Resta entre ambos: {dec - bin}");

            Console.WriteLine("\nPrueba de conversiones a string y double");
            Console.WriteLine((string)bin);
            Console.WriteLine((double)dec);

            Console.WriteLine("\nPrueba de operadores sobrecargados");
            bin = "1000";
            dec = 8;

            Console.WriteLine($"Bin y dec son iguales? {bin == dec}");
            Console.WriteLine($"Bin y dec son distintos? {bin != dec}");

            Console.WriteLine($"\nSuma de bin 1000 mas 10 decimal: {bin + 10}");

            Console.ReadKey();
        }
    }
}
