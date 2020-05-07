using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public abstract class Producto
    {
        private Guid codigo;
        private string descripcion;
        private double precio;
        private int stock;

        protected Producto(string descripcion, int stock, double precio)
        {
            this.descripcion = descripcion;
            this.precio = precio;
            this.stock = stock;
            this.codigo = Guid.NewGuid();
        }

        public string Descripcion
        {
            get { return descripcion; }
            
        }
        public double  Precio
        {
            get { return precio; }
            
        }
        public int Stock
        {
            get 
            {
        
                return stock;
              
            }
            set 
            {
                if (value >= 0)
                {
                    stock =value;
                }
            }
        }

        public static explicit operator Guid(Producto p)
        {
            return p.codigo;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Codigo : {(Guid)this}");
            sb.AppendFormat($"Stock : {this.Stock} ");
            sb.AppendFormat($"Precio :{this.Precio}");
            sb.AppendFormat($"Descripcion : {this.Descripcion}" );
       
            return sb.ToString();
        }
        
    }
}
