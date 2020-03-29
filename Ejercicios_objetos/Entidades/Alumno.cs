using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        #region campos
        private byte notaUno;
        private byte notaDos;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;
        #endregion
        #region constructor
        public Alumno(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;

        }
        #endregion
        #region Metodos
        public void CalcularFinal()
        {
            Random numero = new Random();
            if (this.notaUno >= 4 && this.notaDos >= 4)
            {
                this.notaFinal = numero.Next(1, 11);
            }
            else
            {
                this.notaFinal = -1;
            }

        }
        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.notaUno = notaUno;
            this.notaDos = notaDos;
        }
        public string Mostrar()
        {
            Console.WriteLine($"Nombre del alumno: {this.nombre}");
            Console.WriteLine($"Apellido del alumno: {this.apellido}");
            Console.WriteLine($"Legajo del alumno: {this.legajo}");
            if (notaFinal != -1)
            {
                Console.WriteLine($"Nota final: {this.notaFinal}");
            }
            else
            {
                Console.WriteLine("Alumno desaprobado");
            }
            return ToString();
        }
        #endregion
    }
}

