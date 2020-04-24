using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
#pragma warning disable CS0660, CS0661
    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public abstract float CostoLlamada
        {
            get;
       
        }


        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public float Duracion
        {
            get { return this.duracion; }
        }

        public string NroDestino
        {
            get { return this.nroDestino; }

        }

        public string NroOrigen
        {
            get { return this.nroOrigen; }
        }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"La duracion fue: {this.duracion}");
            sb.AppendLine($"El numero Destino es : {this.nroDestino}");
            sb.AppendLine($"El numero Origen es : {this.nroOrigen}");

            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno = 0;
            if (llamada1.duracion < llamada2.duracion)
            {
                retorno = -1;
            }
            else if (llamada1.duracion > llamada2.duracion)
            {
                retorno = 1;
            }

            return retorno;
        }

        public static bool operator ==(Llamada l1,Llamada l2)
        {
            bool retorno = false;
            if((l1.Equals(l2)) && (l1.nroDestino == l2.nroDestino) && (l1.nroOrigen==l2.nroOrigen))
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }
        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }

    }
}
