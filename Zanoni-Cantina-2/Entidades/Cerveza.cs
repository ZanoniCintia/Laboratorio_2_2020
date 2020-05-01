using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cerveza : Botella
    {
        const int MEDIDA = 330;
        private Tipo tipo;

        public Cerveza(int capacidadMl, string marca, int contenidoMl)
            : this(capacidadMl, marca, Tipo.Vidrio, contenidoMl)
        {

        }

        public Cerveza(int capacidadMl, string marca, Tipo tipo, int contenidoMl)
            : base(capacidadMl, contenidoMl, marca)
        {
            this.tipo = tipo;
        }

        public override int ServirMedida()
        {
            int retorno;
            if (MEDIDA <= Contenido)
            {
                Contenido = Contenido - (MEDIDA * 80) / 100;
                retorno = MEDIDA;

            }
            else
            {
                Contenido = Contenido - Contenido;
                retorno = Contenido;
            }
            return retorno;
        }

        protected new string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Tipo es : {this.tipo}");
            sb.AppendLine($"La medida es : {MEDIDA}");
            return sb.ToString();
        }

        public static implicit  operator Botella.Tipo(Cerveza cerveza)
        {
            return cerveza.tipo; 
        }
    }
}
