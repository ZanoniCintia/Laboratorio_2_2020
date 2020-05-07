using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public sealed class Venta
    {
        private DateTime fecha;
        private static int porcentajeIva;
        private double precioFinal;
        private Producto producto;

        internal DateTime Fecha
        {
            get { return this.fecha; }
            
        }
        internal Venta(Producto producto, int vender)
        {
            this.producto = producto;
            
        }
        static Venta()
        {
            porcentajeIva = 21;
        }
        private void Vender(int cantidad)
        {
            producto.Stock = producto.Stock - cantidad;
            this.fecha = DateTime.Now;
            this.precioFinal = CalcularPrecioFinal(producto.Precio, cantidad);

        }

        public static double CalcularPrecioFinal(double precioUnidad,int cantidad)
        {
            double retorno = 0;
            double final = (precioUnidad * cantidad)*(porcentajeIva/100);
            retorno = (precioUnidad * cantidad) + final;
            return retorno;
            
        }

        public string DescripcionBreve()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Fecha: {this.Fecha} Descripcion :{producto.Descripcion} Precio final :{this.precioFinal}");
            return sb.ToString();
        }

    }
}
