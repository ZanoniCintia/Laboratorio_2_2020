using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
    public class Tienda
    {

        private  List<Pedido> pedidos;
        private  Inventario inventario;
        private  int cantidadDePedidos;
        
        public Tienda()
        {
            pedidos = new List<Pedido>();
            inventario = new Inventario();
        }


        public Inventario Inventario
        {
            get { return this.inventario; }
            set { this.inventario = value; }
        }

        /// <summary>
        /// calcula la ganancia por cada tipo de producto y la suma
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public double CarcularGananciaTotal()
        {
            double total = 0;
            foreach (Pedido aux in this.pedidos)
            {
                total += aux.CalcularGananciaPorPedido(); 
            }
            return total;
        }


        //en esta clase no llegue a nada

        //administra el pedido realizado y el historial de pedidos confirmados
        //tiene q tener un objeto tipo inventario para llevar registro del mismo

    }
}
