using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        private ConsoleColor color;
        private static int valorHora;

        static Automovil()
        {
            valorHora = 50;
        }

        public Automovil(string patente, ConsoleColor color)
            : base(patente)
        {
            this.color = color;
        }

        public Automovil(string patente, ConsoleColor color, int valorHora)
            : this(patente, color)
        {
            Automovil.valorHora = valorHora;
        }

        public override bool Equals(Object obj)
        {
            return obj is Automovil;
        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Automoviles");
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Color : {this.color}");
            sb.AppendLine($"Valor de hora : {Automovil.valorHora}");
            return sb.ToString();
        }

        public override string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Valor estadia: {valorHora * (DateTime.Now.Hour - base.ingreso.Hour)}");
            return sb.ToString();
        }
    }
}
