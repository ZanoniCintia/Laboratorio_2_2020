using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Euro
    {
        private double cantidad;
        static double cotizRespectoDolar;

        static Euro()
        {
            cotizRespectoDolar =0.86;
        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion):this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }

        public  double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Euro.cotizRespectoDolar;
        }

        public static explicit operator Dolar(Euro e)
        {
            return (e.GetCantidad() * Dolar.GetCotizacion());
        }

        public static explicit operator Pesos(Euro e)
        {
            
            return (e.GetCantidad() * Pesos.GetCotizacion());
        }

        public static implicit operator Euro(double e)
        {
            Euro nuevo = new Euro(e);
            return nuevo;
        }
    }
}
