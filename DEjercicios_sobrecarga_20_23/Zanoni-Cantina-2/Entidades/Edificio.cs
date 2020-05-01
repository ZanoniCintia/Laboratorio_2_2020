using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Edificio
    {
        private Cantina[] cantinas;
        private const short limiteCantina=2;
        static Edificio singleton;

        private Edificio()
        {
            this.cantinas = new Cantina[limiteCantina];
        }

        static Edificio()
        {
            singleton = new Edificio();
        }

        public Edificio GetBar()
        {
            return Edificio.singleton;
        }

        public static bool  operator +(Edificio e,Cantina c)
        {
            bool retorno = false;
            int i = 0;
            if(!(e is null) && !(c is null))
            {
                for (i = 0; i < e.cantinas.Length; i++)
                {
                    if (e.cantinas == null)
                    {
                        e.cantinas[i] = c;
                        retorno = true;
                    }
                }
            }
            return retorno;
        }

    }
}
