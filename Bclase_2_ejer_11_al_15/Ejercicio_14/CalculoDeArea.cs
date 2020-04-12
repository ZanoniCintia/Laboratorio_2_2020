using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    public class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            double resultado= lado*lado;
            return resultado;
        }

        public static double CalcularTriangulo(double basee,double altura)
        {
            double resultado= basee*altura/2;
            return resultado;

        }

        public static double CalcularCirculo(double radio)
        {
            float pi = (float)3.14;
            double radioCuadrado = Math.Pow(radio, 2);
            return pi * radioCuadrado;
        }
    }
}
