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

        private List<Pedido> pedidos;
        private Inventario inventario;
        
        /// <summary>
        /// constructor inicializa lista de pedido y un inventario
        /// </summary>
        public Tienda()
        {
            pedidos = new List<Pedido>();
            inventario = new Inventario();
        }

        /// <summary>
        /// propiedad de inventario, de lectura y escritura
        /// </summary>
        public Inventario Inventario
        {
            get
            {
               return inventario;
            }
            set
            {
                inventario = value;
            }
        }

        /// <summary>
        /// calcula la ganancia por cada pedido y la suma
        /// recorre  pedidos dentro del historial de pedidos
        /// vuelve a recorrer buscando un producto dentro de ese pedido encontrado en el foreach anterior
        /// suma el precio total
        /// calcula las ganancias de ese total
        /// retorna un string con los datos obtenidos
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
  
        public static string CalcularGananciaPorPedidos()
        {
            double ganancia = 0;
            double total = 0;
            StringBuilder sb = new StringBuilder();

            foreach (Pedido p in Pedido.HistorialPedidos)
            {
                foreach (Producto item in p.Pedidos)
                {
                    total += item.Precio;
                    ganancia += item.CalcularMargenGanancias;
                }
               
            }
            sb.AppendLine($"Monto total vendido : {total}");
            sb.AppendLine($"Ganancia total  : {ganancia}");

            return sb.ToString();
        }


    }
}
