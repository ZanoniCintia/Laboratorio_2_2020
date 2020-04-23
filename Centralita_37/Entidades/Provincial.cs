using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CentralitaHerencia
{
    public class Provincial :Llamada
    {
        protected Franja franjaHoraria;

        public Provincial(float duracion,string destino,string origen,Franja franjaHoraria)
            :this(franjaHoraria,new Llamada(duracion,destino,origen))
        {
            
        }

        public Provincial(Franja franjaHoraria,Llamada llamada)
            :base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            this.franjaHoraria = franjaHoraria;
        }
        

        public float CostoLlamada
        {
            get
            {
                float retorno = base.duracion * 0.66f;
                if (this.franjaHoraria == Franja.Franja_1)
                {
                    retorno = base.duracion * 0.99f;
                }
                if (this.franjaHoraria == Franja.Franja_2)
                {
                    retorno = base.duracion * 1.25f;
                }
                return retorno;
            }
            
        }
        
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Provincial**");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"El costo de la llamada es {this.CostoLlamada}");
            sb.AppendFormat($"Franja horaria :{this.franjaHoraria}");
            return sb.ToString();


        }

        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
    }
}
