using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
  public  class Perro
    {
        string nombre;
        int edad;

        public Perro(string n,int e)
        {
            this.nombre = n;
            this.edad = e;
        }

        public override string ToString()
        {
            return this.nombre;
        }

        public string DatosCompletos()
        {

            return this.nombre + "  " + this.edad;
        }

    }
}
