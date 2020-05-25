using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MotoCross:VehiculoDeCarrera
    {
		private short cilindrada;

		public short Cilindrada
		{
			get { return this.cilindrada; }
			set { this.cilindrada = value; }
		}

		public MotoCross(short numero, string escuderia)
			:base(numero,escuderia)
		{
			
		}

		public MotoCross(short numero, string escuderia, short cilindrada)
			:this(numero,escuderia)
		{
			this.cilindrada = cilindrada;
		}

		public override string MostrarDatos()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"{base.MostrarDatos()}");
			sb.AppendLine($"Cilindrada : {this.Cilindrada}");
			return sb.ToString();
		}

		public static bool operator ==(MotoCross m1, MotoCross m2)
		{
			return (m1 == m2 && m1.Cilindrada == m2.Cilindrada);
		}

		public static bool operator !=(MotoCross m1, MotoCross m2)
		{
			return (m1 == m2);
		}

	}
}
