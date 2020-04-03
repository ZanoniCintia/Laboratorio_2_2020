using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Dolar
    {
        private double cantidad;
        static double cotizRespectoDolar;

        static Dolar()
        {
            cotizRespectoDolar = 1;
        }
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;

        }

        public Dolar(double cantidad, double cotizacion) : this(cantidad)
        {
            cotizRespectoDolar=cotizacion;
        }

        public  double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Dolar.cotizRespectoDolar;
        }

        public static explicit operator Euro(Dolar d)
        {
            return (d.GetCantidad() / Euro.GetCotizacion());
        }

        public static explicit operator Pesos(Dolar d)
        {
            return (d.GetCantidad() / Pesos.GetCotizacion());
        }

        public static implicit operator Dolar(double d)
        {
            Dolar nuevo=new Dolar(d);
            return nuevo;
        }

        public static bool operator ==(Dolar d1,Dolar d2)
        {
            bool retorno = false;
            if (d1 == d2)
            {
                retorno = true;
            }
            return retorno;

        }
        public static bool operator !=(Dolar d1,Dolar d2)
        {
            return !(d1 == d2);
        }

        public static bool operator ==(Dolar d, Pesos p)
        {
            bool retorno = false;
            if ((Pesos)d== p)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Dolar d,Pesos p)
        {
            return !(d == p);
        }
        public static bool operator ==(Dolar d, Euro e)
        {
            bool retorno = false;
            if ((Euro)d == e)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            Dolar retorno = new Dolar(d.cantidad + ((Dolar)e).cantidad);
            return retorno;
            
        }
         
        public static Dolar operator -(Dolar d, Euro e)
        {
            Dolar retorno = new Dolar(d.cantidad - ((Dolar)e).cantidad);
            return retorno;
        }

        public static Dolar operator +(Dolar d, Pesos p)
        {
            Dolar retorno = new Dolar(d.cantidad + ((Dolar)p).cantidad);
            return retorno;
        }

        public static Dolar operator -(Dolar d, Pesos p)
        {
            Dolar retorno = new Dolar(d.cantidad - ((Dolar)p).cantidad);
            return retorno;
        }
    }
}
