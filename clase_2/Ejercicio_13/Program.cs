using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_13";
            int numero=0;

             Console.WriteLine("Entero a binario");
             Int32.TryParse(Console.ReadLine(), out numero);

             Console.WriteLine($"Resultado :{Conversor.DecimalBinario(numero)}");
             

           Console.WriteLine("Binario a decimal");
            Console.WriteLine($"Resultado: {Conversor.BinarioDecimal(Console.ReadLine())}");
           Console.ReadKey();
        }
    }
}
