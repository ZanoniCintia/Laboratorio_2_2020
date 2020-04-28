using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    #pragma warning disable CS0660, CS0661
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        
        private EMarca marca;
        private string chasis;
        private ConsoleColor color;

        protected Vehiculo(EMarca marca, string chasis, ConsoleColor color)
        {
            this.marca = marca;
            this.chasis = chasis;
            this.color = color;
        }

        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        protected abstract ETamanio Tamanio
        {
            get ;
       
        }

        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }

         public static  explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("CHASIS: {0}\r\n", p.chasis);
            sb.AppendFormat("MARCA : {0}\r\n", p.marca.ToString());
            sb.AppendFormat("COLOR : {0}\r\n", p.color.ToString());
            sb.AppendLine("---------------------");
           
            return sb.ToString();
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1.chasis == v2.chasis);
        }

        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda
        }
        public enum ETamanio
        {
            Chico, Mediano, Grande
        }
    }
}
