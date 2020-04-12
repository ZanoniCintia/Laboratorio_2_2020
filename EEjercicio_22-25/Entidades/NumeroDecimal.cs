using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
#pragma warning disable CS0660, CS0661
    public class NumeroDecimal
    {
        private double numero;

        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        public double GetNumero()
        {
            return this.numero;
        }

        public static bool operator ==(NumeroDecimal nd, NumeroBinario nb)
        {
            double num = Conversor.BinarioDecimal(nb.GetNumero());
            bool retorno = false;
            if (nd.GetNumero() == num)
            {
                retorno = true;
            }

            return retorno;
        }
        public static bool operator !=(NumeroDecimal nd, NumeroBinario nb)
        {
            return !(nd == nb);
        }

        public static double operator +(NumeroDecimal nd, NumeroBinario nb)
        {
            double num1 = Conversor.BinarioDecimal(nb.GetNumero());
            return num1 + nd.GetNumero();

        }

        public static double operator -(NumeroDecimal nd, NumeroBinario nb)
        {
            double num1 = Conversor.BinarioDecimal(nb.GetNumero());
            return nd.GetNumero() - num1;
        }

        public static implicit operator NumeroDecimal(double numero)
        {
            return new NumeroDecimal(numero);
        }
        public static explicit operator double(NumeroDecimal numero)
        {
            return numero.GetNumero();
        }
    }
}
