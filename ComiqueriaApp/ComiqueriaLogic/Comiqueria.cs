using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comiqueria
    {
        private List<Producto> productos;
        private List<Venta> ventas;

        public Comiqueria()
        {
            this.productos = new List<Producto>();
            this.ventas = new List<Venta>();
        }
        public Producto this[Guid codigo]
        {
            get
            {
                //Producto retorno = null;
                foreach (Producto auxProducto in productos)
                {
                    if ((Guid)auxProducto == codigo)
                    {
                        return auxProducto;
                    }
                }
                return null;
            }
        }

        public static bool operator ==(Comiqueria c, Producto p)
        {
            bool retorno = false;
            if (!(c is null) && !(p is null))
            {
                foreach (Producto auxProducto in c.productos)
                {
                    if (auxProducto.Descripcion == p.Descripcion)
                    {
                        retorno = true;
                    }
                }
            }
            return retorno;
        }

        public static bool operator !=(Comiqueria c , Producto p)
        {
            return !(c == p);
        }

        public static Comiqueria operator +(Comiqueria c,Producto p)
        {
            if(!(c is null) && !(p is null))
            {
                foreach (Producto auxProducto in c.productos)
                {
                    if(auxProducto != p)
                    {
                        c.productos.Add(auxProducto);
                    }
                }
            }
            return c;
        }

        public void Vender(Producto producto)
        {
            Vender(producto, 1);
        }
        public void Vender(Producto producto,int cantidad)
        {
            Venta venta = new Venta(producto, cantidad);
            this.ventas.Add(venta);
                 
        }

        public string ListarVentas()
        {
            StringBuilder sb = new StringBuilder();
            ventas.Sort(OrdenarFecha);
            foreach (Venta auxVenta in ventas)
            {
                sb.AppendLine(auxVenta.DescripcionBreve());
            }
            return sb.ToString();
        }
        //crear un metodo que ordene la fecha de las mas reciente a la mas actual

        public int OrdenarFecha(Venta v1, Venta v2)
        {
            int retorno = 0;
            if (v1.Fecha < v2.Fecha)
            {
                retorno = -1;
            }
            else { retorno = 1; }
            return retorno;
        }

        public Dictionary<Guid,string> ListarProductos()
        {
            Dictionary<Guid, string> retorno = new Dictionary<Guid, string>();
            foreach (Producto auxProductos in productos)
            {
                retorno.Add((Guid)auxProductos, auxProductos.Descripcion);
            }
            return retorno;
        }
    }
}
