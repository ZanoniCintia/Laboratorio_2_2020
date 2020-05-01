using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Agua : Botella
    {
        const int MEDIDA = 400; 

        public Agua(int capacidadMl,string marca, int contenidoMl)
            :base(capacidadMl,contenidoMl,marca)
        {

        }
        
        protected  string Generarinforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Medida : {MEDIDA}");
            return sb.ToString();
        }

        public int ServirMedida(int medida)
        {
            int retorno = 0;
            if (medida <= Contenido)
            {
                this.Contenido -= medida;
                retorno = medida;
            }else 
            {
               retorno= this.Contenido;
                this.Contenido = 0;
            }

            return retorno;
        }

        public override int ServirMedida()
        {
            return this.ServirMedida(MEDIDA);
        }


    }
}
