using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicioYear;
            int finalYear;

            Console.WriteLine("Ingrese año de inicio: ");
            inicioYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese año de finalizacion: ");
            finalYear = Convert.ToInt32(Console.ReadLine());

            //Itera por todos los numeros enteros entre los valores ingresados.
            for (int i = inicioYear; i <= finalYear; i++)
            {
                //Prueba si es multiplo de 4.
                if (i % 4 == 0)
                {
                    //Comprueba que no sea multiplo de 100.
                    if (i % 100 != 0)
                    {
                        Console.WriteLine("El año {0} es bisiesto.", i);
                    }
                    else
                    {
                        //Si es multiplo de 100, prueba que tambien lo sea de 400.
                        if (i % 400 == 0)
                        {
                            Console.WriteLine("El año {0} es bisiesto.", i);
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
