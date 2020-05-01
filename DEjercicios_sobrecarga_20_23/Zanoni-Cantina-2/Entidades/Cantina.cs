using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cantina
    {
        private List<Botella> botellas;
        private int espaciosTotales;
        private static Cantina singleton;

        
        public List<Botella> Botellas
        {
            get { return this.botellas; }
            
        }

        private Cantina(int cantina)
        {
            botellas = new List<Botella>();
            this.espaciosTotales = cantina;
        }

        public static Cantina GetCantina(int espacios)
        {
            if(singleton is null)
            {
                singleton = new Cantina(espacios);
            }
            else
            {
                singleton.espaciosTotales=espacios;
            }
            return singleton;
        }
        public static bool operator +(Cantina c,Botella b)
        {
            bool retorno = false;
            if(!(c is null) && !(b is null))
            {
                if(c.botellas.Count< c.espaciosTotales)
                {
                    c.botellas.Add(b);
                    retorno = true;
                }
            }
            return retorno;
        }

    }
}
