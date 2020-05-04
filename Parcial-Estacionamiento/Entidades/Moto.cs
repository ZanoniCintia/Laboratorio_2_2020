using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto:Vehiculo
    {
        private int cilindrada;
        private short ruedas;
        private static int valorHora;

        public override bool Equals(Object obj)
        {
            return obj is Moto;
        }

        static Moto()
        {
            valorHora = 30;
        }

        public Moto(string patente,int cilindrada)
            :base(patente)
        {
            this.ruedas = 2;
            this.cilindrada = cilindrada;
        }

        public Moto(string patente, int cilindrada, short ruedas)
            :this(patente,cilindrada)
        {
            this.ruedas = ruedas;
        }
        public Moto(string patente, int cilindrada, short ruedas, int valorHoras)
            :this(patente,cilindrada,ruedas)
        {
            Moto.valorHora = valorHoras;
        }
         public override string ConsultarDatos()
         {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Motos");
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Cantidad de ruedas : {this.ruedas}");
            sb.AppendLine($"Cilindrada : {this.cilindrada}");
            sb.AppendLine($"Valor hora: {Moto.valorHora}");
            return sb.ToString();
         }

        public override string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.ConsultarDatos());
            sb.AppendLine($"Valor estadia: {valorHora * (DateTime.Now.Hour - base.ingreso.Hour)}");
            return sb.ToString();
        }



    }
}
