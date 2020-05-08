using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Caballo:Animal
    {
        private bool corredor;

        public override bool ComeBalanceado
        {
            get ;
        }
        public override bool ComePasto
        {
            get 
            {
                return true;
            }
        }

        public Caballo(string nombre,int kilos,bool corredor)
            :base(nombre,kilos)
        {
            this.corredor = corredor;

        }

        public override  string Datos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Datos());
            sb.AppendLine($"Es de carrera? si/no: ");
            return sb.ToString();
        }
    }
}
