using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> cliente;
        private string nombre;

        public Negocio()
        {
            this.cliente = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }

        public Negocio(string nombre):this()
        {
            this.nombre = nombre;
        }

        public Cliente Cliente
        {
            get { return this.cliente.Dequeue(); }
            set { cliente.Enqueue(value); }
              
        }

        public static bool operator ==(Negocio neg,Cliente cli2)
        {
            bool retorno = false;
            foreach (Cliente aux in neg.cliente)
            {
                if (aux == cli2)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Negocio neg,Cliente cli2)
        {
            return !(neg == cli2);
        }

        public static bool operator +(Negocio neg,Cliente cli2)
        {
            bool retorno = false;
            if (!(neg == cli2))
            {
                neg.cliente.Enqueue(cli2);
                retorno = true;
            }
            return retorno;
        }
        public static bool operator ~(Negocio neg)
        {
            bool retorno = false;
            if(!(neg is null))
            {
                Cliente aux=neg.Cliente;
                if(!(aux is null))
                {
                    neg.caja.Atender(aux);
                    retorno =true;
                }
            }
            return retorno;
        }
    }
}
