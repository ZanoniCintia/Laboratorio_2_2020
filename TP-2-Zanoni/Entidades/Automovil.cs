using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Automovil:Vehiculo
    {
        
        private ETipo tipo;

        /// <summary>
        /// Por defecto, TIPO será Monovolumen
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Automovil(EMarca marca, string codigo, ConsoleColor color)
          : this(marca, codigo, color, ETipo.Monovolumen)
        {
           
        }

        public Automovil(EMarca marca,string codigo,ConsoleColor color,ETipo tipo)
          :base(marca,codigo,color)  
        {
            this.tipo = ETipo.Monovolumen;
        }


        /// <summary>
        /// Los automoviles son medianos
        /// </summary>
        protected override ETamanio Tamanio
        {

            get { return ETamanio.Mediano; }
            
        }

        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("AUTOMOVIL");
            sb.AppendLine(this.Mostrar());
            sb.AppendLine($"TAMAÑO :{this.Tamanio}");
            sb.AppendLine($"TIPO :{this.tipo} ");
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        public enum ETipo { Monovolumen, Sedan }
    }
}
