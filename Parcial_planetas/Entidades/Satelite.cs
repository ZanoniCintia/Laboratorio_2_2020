using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Satelite:Astro
    {
		public Satelite(int duracionOrbita, int duracionRotacion, string nombre) 
			: base(duracionOrbita, duracionRotacion, nombre)
		{
		}

		public string Nombre
		{
			get { return base.nombre; }
		}

		public override string Orbitar()
		{
			return string.Format($"Orbitar el satelite: {this.Nombre}");
		}

		public override string ToString()
		{
			return base.Mostar();
		}




	}
}
