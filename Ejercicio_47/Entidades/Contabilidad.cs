using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   // c.Tanto el tipo genérico T como el U deberán ser del tipo Documento o uno de sus derivados.
   // d.El tipo U deberá tener una restricción que indique que deberá tener un constructor por defecto (sin argumentos).
    public class Contabilidad<T,U>
    {
        private List<T> egresos;
        private List<U> ingresos;

        private Contabilidad()
        {
            this.egresos = new List<T>();
            this.ingresos = new List<U>();
        }

        public static Contabilidad<T,U> operator +(Contabilidad<T,U> cont, T egreso )
        {
            cont.egresos.Add(egreso);
            return cont;
        }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> cont, U ingreso)
        {
            cont.ingresos.Add(ingreso);
            return cont;
        }
    }
}
