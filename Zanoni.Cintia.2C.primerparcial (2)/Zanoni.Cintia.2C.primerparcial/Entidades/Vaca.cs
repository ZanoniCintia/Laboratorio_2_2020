using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vaca:Animal
    {
        private Clasificacion  clasificacion;

        public override bool ComePasto
        {
            get
            {
                return true;
            }
        }
        public override bool ComeBalanceado
        {
            get
            {
                return false;
            }
        }

        public Vaca(string nombre,int kilosAlimento)
            : base(nombre, kilosAlimento)
        {

        }

        public Vaca(string nombre,int kilosAlimento,Clasificacion clasificacion)
            : this(nombre, kilosAlimento)
            
        {
            this.clasificacion = clasificacion;
        }

        public override string Datos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Datos());
            sb.AppendLine($"Clasificada como : {this.clasificacion}");
            return sb.ToString();
        }

        public enum Clasificacion
        {
            Lechera,
            Normando,
            Pasiega,
            HolandoArgentina,
            Tudanca
        }
    }
}
