using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 29";
            //no muestra!!! 
            Jugador j1 = new Jugador(222, "joe", 6, 3);
            Jugador j2 = new Jugador(333, "jorel", 6, 3);
            j2.MostrarDatos();
            j1.MostrarDatos();
         
          
            Console.ReadKey();


        }
    }
}
