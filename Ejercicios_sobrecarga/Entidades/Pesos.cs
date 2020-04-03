using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pesos
    {
        private double cantidad;
        static double cotizRespectoDolar;

        static Pesos()
        {
            cotizRespectoDolar = 38.33;
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public  Pesos(double cantidad, double cotizacion):this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }

        public  double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return Pesos.cotizRespectoDolar;
        }
        public static explicit operator Dolar(Pesos p)
        {
            return (p.GetCantidad() * Dolar.GetCotizacion());
        }
        public static explicit operator Euro(Pesos p)
        {
            double retorno= ((Dolar)p).GetCantidad() / Euro.GetCotizacion();
            return new Euro(retorno);
        }
        public static implicit operator Pesos(double p)
        {
            Pesos nuevo = new Pesos(p);
            return nuevo;
        }

    }
}
