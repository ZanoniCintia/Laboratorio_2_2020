using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TurnoRepetidoException:Exception
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="mensaje"></param>
        public TurnoRepetidoException(string mensaje) : this(mensaje, null)
        {

        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="innerException"></param>
        public TurnoRepetidoException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }
    }


    public class RutaNoExisteException : Exception
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="mensaje"></param>
        public RutaNoExisteException(string mensaje) : this(mensaje, null)
        {

        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="innerException"></param>
        public RutaNoExisteException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }
    }
}
