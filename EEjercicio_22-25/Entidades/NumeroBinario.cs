using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
#pragma warning disable CS0660, CS0661
    public class NumeroBinario
    {
        private string numero;

        private NumeroBinario(string numero)
        {
            this.numero = numero;
        }

        public string GetNumero()
        {
            return this.numero;
        }

        public static string operator +(NumeroBinario nb, NumeroDecimal nd)
        {
            string resultado = "";
            double num1 = nd.GetNumero();
            double num2 = Conversor.BinarioDecimal(nb.GetNumero());
            num1 += num2;
            resultado = Conversor.DecimalBinario(num1);
            return resultado;
        }

        public static string operator -(NumeroBinario nb, NumeroDecimal nd)
        {
            string resultado = "";
            double num1 = nd.GetNumero();
            double num2 = Conversor.BinarioDecimal(nb.GetNumero());
            num1 -= num2;
            if (num1 < 0)
            {
                resultado = "Invalido";
            }
            else
            {
                resultado = Conversor.DecimalBinario(num1);
            }

            return resultado;
        }

        public static bool operator ==(NumeroBinario nb, NumeroDecimal nd)
        {
            string num = Conversor.DecimalBinario(nd.GetNumero());
            bool retorno = false;
            if (nb.GetNumero() == num)
            {
                retorno = true;
            }

            return retorno;

        }

        public static bool operator !=(NumeroBinario nb, NumeroDecimal nd)
        {
            return !(nb == nd);
        }

        public static implicit operator NumeroBinario(string numero)
        {
            return new NumeroBinario(numero);
        }

        public static explicit operator string(NumeroBinario numero)
        {
            return numero.GetNumero().ToString();
        }

    }
}
