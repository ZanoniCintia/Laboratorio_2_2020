using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 15";
            Alumno primerAlumno = new Alumno("Cintia","Zanoni",1);
            primerAlumno.Estudiar(4, 6);
            primerAlumno.CalcularFinal();
            primerAlumno.Mostrar();

            Alumno segundoAlumno = new Alumno("Gaston", "Picazo", 2);
            segundoAlumno.Estudiar(2, 3);
            segundoAlumno.CalcularFinal();
            segundoAlumno.Mostrar();

            Alumno tercerAlumno = new Alumno("Joe", "Morello", 3);
            tercerAlumno.Estudiar(9, 10);
            tercerAlumno.CalcularFinal();
            tercerAlumno.Mostrar();

            Console.ReadKey();
        }
    }
}
