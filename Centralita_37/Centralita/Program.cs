using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralitaHerencia;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //mi central
            Centralita c = new Centralita("Cintia center");

            //mis 4 llamadas
            Local llamada1 = new Local(30,"Varela","Avellaneda",2.65f);
            Provincial llamada2 = new Provincial(21,"Cordoba","BsAs",Provincial.Franja.Franja_1);
            Local llamada3 = new Local(45, "Lanus", "caba", 1.99f);
            Provincial llamada4 = new Provincial(Provincial.Franja.Franja_3, llamada2);

            //las llamadas se iran registrando en la centralita
            //la centralita mostrara por pantalla todas las llamadas segun las vaya registrando
            c.Llamadas.Add(llamada1);
            Console.WriteLine(c.Mostrar());

            c.Llamadas.Add(llamada2);
            Console.WriteLine(c.Mostrar());

            c.Llamadas.Add(llamada3);
            Console.WriteLine(c.Mostrar());

            c.Llamadas.Add(llamada4);
            Console.WriteLine(c.Mostrar());

            Console.WriteLine("******En orden**********");
            c.OrdenarLlamadas();
            Console.WriteLine(c.Mostrar());
            Console.ReadKey();
        }
    }
}
