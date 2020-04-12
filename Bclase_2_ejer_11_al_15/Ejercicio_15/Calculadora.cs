using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    public class Calculadora
    {
        public static double Calcular(double primerNumero,double SegundoNumero, string operacion)
        {
            double resultado=0;
            
            switch (operacion)
            {
                case "+":
                    resultado = primerNumero + SegundoNumero;
                    break;
                case "-":
                    resultado = primerNumero - SegundoNumero;
                    break;
                case "*":
                    resultado = primerNumero * SegundoNumero;
                    break;
                case "/":
                    if ( Validar(SegundoNumero))
                    {
                        resultado = primerNumero / SegundoNumero;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                    
            }
            return resultado;
        }

        private static bool Validar(double numero)
        {
            bool retorno = false;
            if (numero != 0)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
