using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Botella
    {
        protected int capacidadMl;
        protected int contenidoMl;
        protected string marca;

        protected Botella(int capacidadMl, int contenidoMl, string marca)
        {
            this.capacidadMl = capacidadMl;
            this.contenidoMl = contenidoMl;
            this.marca = marca;
        }

        public int CapacidadDeLitros
        {
            get { return (this.capacidadMl)/1000; }
            
        }

       

        public int Contenido
        {
            get { return contenidoMl; }
            set { contenidoMl = value; }
        }
       
        public float PorcentajeContenido
        {
            get 
            { 
                return (this.contenidoMl*100)/capacidadMl; 
            }
            
        }

        protected virtual string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Marca : {this.marca}");
            sb.AppendLine($"Contenido : {Contenido}");
            sb.AppendLine($"La capacidad : {CapacidadDeLitros}");
            sb.AppendLine($"El porcentaje es : {PorcentajeContenido}%");
            return sb.ToString();
        }

        public new string ToString()
        {
            return GenerarInforme();
        }

        public abstract int ServirMedida();

        public enum Tipo
        {
            Plastico, Vidrio
        }

    }
}
