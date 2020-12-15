using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pedido
    {
        private TipoDeUsuario usuario;
        private List<Producto> pedidos;
        private int cantidad;

        /// <summary>
        /// constructor privado instancia lista de productos
        /// </summary>
        public Pedido()
        {
            this.pedidos = new List<Producto>();

        }

        /// <summary>
        /// constructor publico recibe un tipo enumerado, invoca constructor de instancia
        /// </summary>
        /// <param name="usuario"></param>
        public Pedido(TipoDeUsuario usuario)
            : this()
        {
            this.usuario = usuario;
        }

      
        public int Cantidad
        {
            get { return this.cantidad; }

        }


        /// <summary>
        /// operador + si el cantidad de productos agregados es >= al stock, lo agrega a la lista de pedido
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="pedido"></param>
        /// <returns></returns>
        public static bool operator +(Producto producto, Pedido pedido)
        {
            if (pedido.cantidad >= producto.Stock)
            {
                pedido.pedidos.Add(producto);
                producto.Stock++;
                return true;
            }
            return false;
        }


        /// <summary>
        /// operador -,elimina el producto cargado comparando con el que se quiere eliminar
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="pedido"></param>
        /// <returns></returns>
        public static bool operator -(Producto producto, Pedido pedido)
        {
            foreach (Producto p in pedido.pedidos)
            {
                if (p == producto)
                {
                    pedido.pedidos.Remove(p);
                    return true;
                }
            }
            return false;
        }



        /// <summary>
        /// Calcula precio total del pedido sumando el precio de cada producto ingresado al pedido
        /// </summary>
        /// <param name="pedido"></param>
        /// <returns></returns>
        
        public double PrecioTotal(Pedido pedido)
        {
            double total = 0;
            foreach (Producto p in pedido.pedidos)
            {
                total += p.Precio;
            }
            return total;
        }
        public double CalcularGananciaPorPedido() 
        {
            double total = 0;
            foreach (Producto p in this.pedidos)
            {
                total += p.Precio;
            }
            return total;
        }
       

        /*public int CantidadStock(Pedido p)
        {
            int retorno = 0;
            foreach (Producto auxProducto in p.pedidos)
            {
                retorno += auxProducto.Stock;
            }
            return retorno;
        }*/


        //operador + agrega elementos al pedido
        //operador - los elimina de la lista
        //sumar el total de los productos ingresados y sus ganancias
    }
}
