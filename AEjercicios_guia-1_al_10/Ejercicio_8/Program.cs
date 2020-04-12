using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 8";
            string nombre;
            float valorHora;
            int antiguedad;
            int horasTrabajadas;
            float sueldoBruto;
            float sueldoNeto;
            float descuentos;
            char respuesta;

            do
            {
                Console.WriteLine("Ingrese nombre: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese valor hora: ");
                valorHora = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Ingrese antiguedad: ");
                antiguedad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese horas trabajadas: ");
                horasTrabajadas = Convert.ToInt32(Console.ReadLine());

                sueldoBruto = horasTrabajadas * valorHora + antiguedad * 150;
                descuentos = sueldoBruto * (float)0.13;
                sueldoNeto = sueldoBruto * (float)0.87;

                Console.WriteLine("Nombre: {0}", nombre);
                Console.WriteLine("Antiguedad: {0}", antiguedad);
                Console.WriteLine("Valor hora: {0}", valorHora);
                Console.WriteLine("Sueldo bruto: {0}", sueldoBruto);
                Console.WriteLine("Descuentos: {0}", descuentos);
                Console.WriteLine("Sueldo neto: {0}", sueldoNeto);
                Console.WriteLine();
                Console.WriteLine("Desea volver a calcular [S/N]:");
                respuesta = Convert.ToChar(Console.ReadLine());

            } while (respuesta == 'S');

            Console.ReadKey();
        }
    }
}
