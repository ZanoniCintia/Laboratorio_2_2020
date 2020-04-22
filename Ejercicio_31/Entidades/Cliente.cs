using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
#pragma warning disable CS0660, CS0661
    public class Cliente
    {
        private string nombre;
        private int numero;

        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(string nombre, int numero):this(numero)
        {
            this.nombre = nombre;
            
        }

      

        public string Nombre
        {
            get { return this.nombre; }
            set { nombre = value; }
        }

        public int Numero
        {
            get { return this.numero; }
            
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return c1.numero == c2.numero;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }

    }
}
