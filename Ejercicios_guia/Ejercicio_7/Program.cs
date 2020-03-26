using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 7";
            //int nacimiento;
            int dia;
            int mes;
            int anio;
            DateTime hoy= DateTime.Now;
            int contadorDeDias = 0;

            Console.WriteLine("Ingrese su dia de nacimiento: ");
            dia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese mes de su nacimiento : ");
            mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese año de su nacimiento : ");
            anio = Convert.ToInt32(Console.ReadLine());

            

           
        }
    }
}
