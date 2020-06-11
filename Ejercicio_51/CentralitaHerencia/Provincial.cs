using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial:Llamada
    {
        protected Franja franjaHoraria;

        public Provincial()
        {

        }
        public Provincial(Franja miFranja, Llamada llamada)
            : this(miFranja, llamada.NroOrigen, llamada.Duracion, llamada.NroDestino)
        {

        }
        public Provincial(Franja miFranja, string origen, float duracion, string destino)
            : base(duracion, destino, origen)
        {

        }

        public override float CostoLlamada
        {
            get
            {
                float retorno = base.duracion * 0.66f;
                if (this.franjaHoraria == Franja.Franja_1)
                {
                    retorno = base.duracion * 0.99f;
                }
                else if (this.franjaHoraria == Franja.Franja_2)
                {
                    retorno = base.duracion * 1.25f;
                }
                return retorno;
            }
        }

        private float CalcularCosto()
        {
            return CostoLlamada;
        }
        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Provincial**");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"El costo de la llamada es {this.CostoLlamada}");
            sb.AppendFormat($"Franja horaria :{this.franjaHoraria}");
            return sb.ToString();


        }
        public override string ToString()
        {
            return Mostrar();
        }

        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
    }
}
