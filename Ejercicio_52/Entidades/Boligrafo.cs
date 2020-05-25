using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Boligrafo
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public ConsoleColor Color
        {
            get { return this.colorTinta; }
            set { colorTinta = value; }
        }

        public float UnidadDeEscritura
        {
            get { return this.tinta; }
            set { tinta = value; }
        }



    }
}
