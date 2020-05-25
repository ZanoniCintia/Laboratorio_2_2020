using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
#pragma warning disable CS0660, CS0661

    public class AutoF1:VehiculoDeCarrera
    {
        private short caballoDeFuerza;

        public short CaballoDeFuerza
        {
            get { return this.caballoDeFuerza; }
            set { this.caballoDeFuerza = value; }
        }

        public AutoF1(short numero,string escuderia)
            : base(numero, escuderia)
        {

        }
        public AutoF1(short numero, string escuderia,short caballoDeFuerza)
            : this(numero, escuderia)           
        {
            this.caballoDeFuerza = caballoDeFuerza;
        }

        public override string  MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.MostrarDatos()}");
            sb.AppendLine($"Caballos de fuerza : {this.CaballoDeFuerza}");
            return sb.ToString();
        }


        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return (a1 == a2 && a1.CaballoDeFuerza == a2.CaballoDeFuerza);
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

    }
}
