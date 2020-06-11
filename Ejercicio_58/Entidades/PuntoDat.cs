using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO
{
    public class PuntoDat:Archivo
    {
		private string contenido;

		public string Contenido
		{
			get { return contenido; }
			set { contenido = value; }
		}

	}
}
