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
        public static void SetCotizacion(double cotizacion)
        {
           Pesos.cotizRespectoDolar= cotizacion;
        }

        public static explicit operator Dolar(Pesos p)
        {
            return new Dolar(p.GetCantidad() / Pesos.GetCotizacion());
        }

        public static explicit operator Euro(Pesos p)
        {
            Dolar retorno = (Dolar)p;
            return (Euro)retorno;
        }

        public static implicit operator Pesos(double p)
        {
            Pesos nuevo = new Pesos(p);
            return nuevo;
        }

        public static bool operator ==(Pesos p, Dolar d)
        {
            bool retorno = false;
            if (p == (Pesos)d)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == d);
        }

        public static bool operator ==( Pesos p, Euro e)
        {
            bool retorno = false;
            if (p == (Pesos)e)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=( Pesos p,Euro e)
        {
            return !(p == e);
        }

        public static bool operator ==(Pesos p1, Pesos p2)
        {
            bool retorno = false;
            if (p1 == p2)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }

        public static Pesos operator +(Pesos p, Dolar d)
        {
            Pesos retorno = new Pesos(p.cantidad + ((Pesos)d).cantidad);
            return retorno;
        }
        public static Pesos operator -(Pesos p, Dolar d)
        {
            Pesos retorno = new Pesos(p.cantidad - ((Pesos)d).cantidad);
            return retorno;
        }

        public static Pesos operator +( Pesos p, Euro e)
        {
            Pesos retorno = new Pesos(p.cantidad + ((Pesos)e).cantidad);
            return retorno;
        }

        public static Pesos operator -(Pesos p, Euro e)
        {
            Pesos retorno = new Pesos(p.cantidad - ((Pesos)e).cantidad);
            return retorno;
        }

    }
}
