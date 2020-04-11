using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_5
{
    public class Estante
    {
        private int ubicacionEstante;
        private Producto[] productos;

        private Estante(int capacidad)
        {   
            this.productos=new Producto[capacidad];
        }

        public Estante(int capacidad,int ubicacion):this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }
        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"La ubicacion es :{e.ubicacionEstante}");
            foreach (Producto aux in e.productos)
            {
                sb.AppendLine($"Productos: {Producto.MostrarProducto(aux)}");
            }

            return sb.ToString();
        }

        public static bool operator ==(Estante e,Producto p)
        {
            bool retorno = false;
            if (e.productos.Contains(p))
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static Estante operator -(Estante e, Producto p)
        {
            if (e == p)
            {

                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] == p)
                    {
                        e.productos[i] = null;
                    }
                }
            }
            return e;

        }
        public static bool operator +(Estante e, Producto p)
        {
            bool retorno = false;
            if (e != p)
            {

                for (int i = 0; i < e.productos.Length; i++)
                {
                    // Si es null queda espacio.
                    if (e.productos[i] is null)
                    {
                        e.productos[i] = p;
                        retorno = true;
                        break;
                    }
                }
            }

            return retorno;
        }
    }
}
