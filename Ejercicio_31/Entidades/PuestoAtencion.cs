using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class PuestoAtencion
    {
        private int numeroActual;
        private Puesto puesto;

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        private PuestoAtencion()
        {
            this.numeroActual = 0;
        }

        public int NumeroActual
        {
            get 
            {
                numeroActual++;
                return this.numeroActual; 
            }
           
        }

        public bool Atender(Cliente cli)
        {
            Thread.Sleep(300);
            return true;

        }



        public enum Puesto
        {
            Caja1,
            Caja2
        }
    }
}
