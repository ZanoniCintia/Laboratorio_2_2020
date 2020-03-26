using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 5";
            int numero;
            int anterior;
            int posterior;
            int centroNumerico=0;

            Console.WriteLine("Ingrese un numero");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero == 0)
            {
                Console.WriteLine("Error, ingrese un numero mayor a cero");
                numero = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                //Itera hasta el numero ingresado
                for (int i = 1; i<=numero ; i++)
                {
                    anterior = 0;
                    posterior = 0;

                    //Suma todos los numeros anteriores positivos al indice
                    for(int j=numero-1; j>0; j--)
                    {
                        anterior +=j;
                    }
                    //Suma los numeros posteriores al indice mientras la suma sea menor 
                    //a la suma de los anteriores
                    for (int k=numero+1; posterior < anterior; k++)
                    {
                        posterior += k;
                    }
                    //Prueba si la suma de los anteriores es igual a la suma de los posteriores.
                    if (anterior==posterior)
                    {
                        centroNumerico = numero;
                    }
                    Console.WriteLine($"Centros numericos {i}");
                }
                

            }


            Console.ReadKey();

        }
    }
}
