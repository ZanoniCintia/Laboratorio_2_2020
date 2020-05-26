using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local:Llamada
    {
        protected float costo;

        public Local(Llamada llamada, float costo)
            : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {

        }
        public Local(string origen, float duracion, string destino, float costo)
            : base(duracion, destino, origen)
        {
            this.costo = costo;

        }

        private float CalcularCosto()
        {
            float retorno = this.duracion * this.costo;
            return retorno;

        }

        public override float CostoLlamada
        {
            get { return CalcularCosto(); }

        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Local**");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"El costo es : {this.costo}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return base.Mostrar();
        }

        public override bool Equals(Object obj)
        {
            return obj is Local;
        }

     

    }
}
