using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_57
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Cintia", "Zanoni");
            Persona p2 = new Persona();

            Persona.Guardar(p1);

            Console.WriteLine(p1.ToString());

            Console.ReadKey();
        }
    }
}
