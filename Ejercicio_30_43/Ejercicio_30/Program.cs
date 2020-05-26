using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia competencia1 = new Competencia(3,14,Competencia.TipoCompetencia.F1);
            
            VehiculoDeCarrera auto1 = new AutoF1(3,"chevrolet",7);
            VehiculoDeCarrera auto2 = new AutoF1(4,"fiat",5);
            VehiculoDeCarrera auto3 = new AutoF1(6,"Ford",8);
            VehiculoDeCarrera moto1 = new MotoCross(8,"Vulcan", 1000);
            VehiculoDeCarrera moto2 = new MotoCross(5,"Mt07", 600);
            VehiculoDeCarrera moto3 = new MotoCross(1,"KLR", 1500);


            try
            {
                if (competencia1 + auto1)
                {
                    Console.WriteLine($"Se agregó ");
                }
                else
                {
                    Console.WriteLine($"No se pudo agregar");
                }
                if (competencia1 + auto2)
                {
                    Console.WriteLine($"Se agregó ");
                }
                else
                {
                    Console.WriteLine($"No se pudo agregar");
                }

                if (competencia1 + moto1)
                {
                    Console.WriteLine($"Se agregó ");
                }
                else
                {
                    Console.WriteLine($"No se pudo agregar");
                }
                if (competencia1 + auto3)
                {
                    Console.WriteLine($"Se agregó ");
                }
                else
                {
                    Console.WriteLine($"No se pudo agregar");
                }
                if (competencia1 + moto2)
                {
                    Console.WriteLine($"Se agregó ");
                }
                else
                {
                    Console.WriteLine($"No se pudo agregar");
                }
                if (competencia1 - auto2)
                {
                    Console.WriteLine($"Se elimino \n ");
                }
                else
                {
                    Console.WriteLine("no se pudo \n");
                }
                if (competencia1 + moto3)
                {
                    Console.WriteLine($"Se agregó ");
                }
                else
                {
                    Console.WriteLine($"No se pudo agregar");
                }

            }
            catch (CompetenciaNoDisponibleException e)
            {

                Console.WriteLine(e.ToString());
            }
            Console.WriteLine(competencia1.MostrarDatos());
            Console.ReadKey();


        }
    }
}
