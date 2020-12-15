using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Pedido
    {
        public TipoDeUsuario usuario;
        public List<Producto> pedidos;
        public static List<Pedido> historialPedidos;
        public DateTime fechaPedido;

        /// <summary>
        /// propiedas de lectura retorna una lista de pedidos
        /// </summary>
        public List<Producto> Pedidos 
        {
            get { return pedidos; }
          
        }

        /// <summary>
        /// constructos static para acceder a una lista fija de pedidos en el resto del codigo
        /// </summary>
        static Pedido()
        {
            historialPedidos = new List<Pedido>();
        }


        /// <summary>
        /// propiedad estatica de lectura y escritura de su lista unica
        /// </summary>
        public static List<Pedido> HistorialPedidos
        {
            get { return Pedido.historialPedidos; }
            set { Pedido.historialPedidos = value; }
        }



        /// <summary>
        /// constructor privado instancia lista de productos
        /// </summary>
        public Pedido()
        {
            this.pedidos = new List<Producto>();
            this.fechaPedido = DateTime.Now;
        }

        /// <summary>
        /// constructor publico recibe  una lista, invoca constructor de instancia
        /// </summary>
        /// <param name="usuario"></param>
        public Pedido (List<Producto> pedido)//TipoDeUsuario usuario
            : this()
        {
            this.pedidos = pedido;
        }

      
        


        /// <summary>
        /// operador + si el cantidad de productos agregados es >= al stock, lo agrega a la lista de pedido
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="pedido"></param>
        /// <returns></returns>
        public static bool operator +(Producto producto, Pedido auxPedido)
        {
            if ( producto.Stock >=0 && producto.CantidadPedidaCliente>0)
            {
                auxPedido.Pedidos.Add(producto);
                return true;
            }
            return false;
        }


        /// <summary>
        /// operador -,elimina el producto cargado comparando que el que se quiere eliminar sea igual al seleccionado
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
                    pedido.Pedidos.Remove(p);
                    return true;
                }
            }
            return false;
        }



        /// <summary>
        /// Calcula precio total del pedido sumando el precio de cada producto ingresado al pedido
        /// recorre la lista de productos en el pedido y suma el precio de cada producto
        /// </summary>
        /// <param name="pedido"></param>
        /// <returns></returns>
        
        public double PrecioTotal(List<Producto> pedido)
        {
            double total = 0;
            foreach (Producto p in pedido)
            {
                total += p.Precio;
            }
            return total;
        }

      

      /// <summary>
      /// sobrecarga de toString retornando la fecha en que se relalizo el pedido mediante un DateTime
      /// </summary>
      /// <returns></returns>

        public override string ToString()
        {
            return $"Fecha pedido : {this.fechaPedido.ToString()}"; 
        }


    }
}
