using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PickUp : Vehiculo
    {
        private string modelo;
        private static int valorHora;

        public override bool Equals(Object obj)
        {
            return obj is PickUp;
        }

        static PickUp()
        {
            valorHora = 70;
        }

        public PickUp(string patente, string modelo)
            :base(patente)
        {
            this.modelo = modelo;
        }
        public PickUp(string patente,string modelo, int valorHora)
            :this(patente,modelo)
        {
            PickUp.valorHora = valorHora;
        }
        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("PickUp");
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Modelo: {this.modelo}");
            sb.AppendLine($"Valor de Hora : {PickUp.valorHora}");
            return sb.ToString();
        }

        public override string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.ConsultarDatos());
            sb.AppendLine($"Valor de estadia: {PickUp.valorHora * (DateTime.Now.Hour - base.ingreso.Hour)}");
            return sb.ToString();
        }
    }
}
