using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VehiculoDeCarrera
    {
        private short cantidadCombustible;
        private bool competencia;
        private string escuderia;
        private short numero;
        private short vueltaRestante;

        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.escuderia = escuderia;
            this.numero = numero;
            this.competencia = false;
            this.vueltaRestante = 0;
            this.cantidadCombustible = 0;
        }

        public short CantidadCombustible
        {
            get { return cantidadCombustible; }
            set { cantidadCombustible = value; }
        }

        public bool EnCompetencia
        {
            get { return competencia; }
            set { competencia = value; }
        }

        public short VueltasRestantes
        {
            get { return vueltaRestante; }
            set { vueltaRestante = value; }
        }

        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Numero :{this.numero}");
            sb.AppendLine($"Escuderia :{this.escuderia}");
            sb.AppendLine($"Competencia :{this.competencia}");
            sb.AppendLine($"Vueltas restantes :{this.vueltaRestante}");
            sb.AppendLine($"Cantidad de combustible :{this.cantidadCombustible}");
            return sb.ToString();
        }

        public static bool operator ==(VehiculoDeCarrera a1, VehiculoDeCarrera a2)
        {

            return a1.escuderia == a2.escuderia && a1.numero == a2.numero;
        }
        public static bool operator !=(VehiculoDeCarrera a1, VehiculoDeCarrera a2)
        {
            return !(a1 == a2);
        }

    }
}
