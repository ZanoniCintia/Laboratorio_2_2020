using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Recibo:Documento
    {
        public Recibo()
            :this(new int())//lo tuve q ver no se porq va eso
        {

        }

        public Recibo(int numero)
            : base(numero)
        {

        }
    }
}
