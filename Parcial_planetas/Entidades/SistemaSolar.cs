using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class SistemaSolar
	{
		private List<Astro> planetas;

		private SistemaSolar()
		{
			planetas=new List<Astro>();
		}

		public List<Astro> Planetas
		{
			get { return this.Planetas; }
			
		}

		public string MostrarInformacionAstros()
		{
			StringBuilder sb = new StringBuilder();
			foreach (Planeta planeta in planetas)
			{
				sb.AppendLine(planeta.ToString());
				foreach(Satelite satelite in planeta.Satelite)
				{
					sb.AppendLine(satelite.ToString());
				}
			}
			return sb.ToString();
		}



	}
}
