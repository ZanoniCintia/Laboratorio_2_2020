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
            cotizRespectoDolar = 0.86;
        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Euro.cotizRespectoDolar;
        }

        public static void SetCotizacion(double cotizacion)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }

        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.GetCantidad() / Euro.GetCotizacion());
        }

        public static explicit operator Pesos(Euro e)
        {
            Dolar retorno = (Dolar)e;
            return (Pesos)retorno;

        }

        public static implicit operator Euro(double e)
        {
            Euro e1 = new Euro(e);
            return e1; 
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            bool retorno = false;
            if (e == (Dolar)d)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static bool operator ==(Euro e, Pesos p)
        {
            bool retorno = false;
            if (e == (Pesos)p)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            bool retorno = false;
            if (e1 == e2)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Euro e1,Euro e2)
        {
            return !(e1 == e2);
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            Euro retorno = new Euro(e.cantidad + ((Euro)d).cantidad);
            return retorno;
        }
        public static Euro operator -(Euro e, Dolar d)
        {
            Euro retorno = new Euro(e.cantidad - ((Euro)d).cantidad);
            return retorno;
        }

        public static Euro operator +(Euro e, Pesos p)
        {
            Euro retorno = new Euro(e.cantidad + ((Euro)p).cantidad);
            return retorno;
        }

        public static Euro operator -(Euro e, Pesos p)
        {
            Euro retorno = new Euro(e.cantidad - ((Euro)p).cantidad);
            return retorno;
        }
    }

}
