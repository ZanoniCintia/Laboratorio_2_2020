using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CentralitaHerencia
{
    public class Local :Llamada
    {
        protected float costo;

        /* public Local( float duracion, string destino, string origen, float costo)
             : this(new Llamada(duracion, destino, origen),costo)
         {

         }

         public Local(Llamada llamada, float costo) 
         : base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
         {
             this.costo = costo;
         }*/
        public Local(Llamada llamada, float costo) 
            : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {

        }
        public Local(string origen, float duracion, string destino, float costo) 
            : base(duracion, destino, origen)
        {
            this.costo = costo;

        }

        public float CostoLlamada
        {
            get { return this.costo * this.duracion; }
           
        }

        public string  Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Local**");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"El costo es : {this.costo}");
           
            return sb.ToString();
        }



    }
}
