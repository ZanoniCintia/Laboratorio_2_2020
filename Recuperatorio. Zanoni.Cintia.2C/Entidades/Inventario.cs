using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Inventario
    {
        private List<Producto> productos;


        /// <summary>
        /// constructor de instancia
        /// </summary>
        public Inventario()
        {
            this.productos = new List<Producto>();
        }

        /// <summary>
        /// propiedad solo lectura retorna lista
        /// </summary>
        public List<Producto> Productos 
        {
            get
            { 
                return this.productos; 
            }
        }

        /// <summary>
        /// recibe un producto , si aun no esta  ingresado en la lista lo agrega y rotorna true
        /// si se quiere ingresar el mismo producto retorna false
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool AgregarProductoAlStock(Producto p)
        {
            bool retorno = true;
            if(!(p is null))
            {
                foreach (Producto auxProducto in this.productos)
                {
                    if(p==auxProducto)
                    {
                        retorno = false;
                        break;
                    }                 
                }
                if (retorno)
                {
                    this.productos.Add(p);
                }
            }
            return retorno;
        }

        /// <summary>
        /// elimina un producto ingresando su nombre(marca) y su ambito 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="ambito"></param>
        /// <returns></returns>
        public bool EliminarProductoStock(string nombre,TipoDeAmbito ambito)
        {
            bool retorno = false;
            foreach (Producto p in this.productos)
            {
                if(p.Nombre==nombre && p.Ambito == ambito)
                {
                    this.productos.Remove(p);
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
       
        /// <summary>
        /// busca un producto por su nombre y ambito, lo muestra si el mismo se encuentra en stock
        /// </summary>
        /// <param name="nombreProducto"></param>
        /// <param name="categoria"></param>
        /// <returns></returns>
        public string BuscarProducto(string nombreProducto, TipoDeAmbito categoria)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Producto p in this.productos)
            {
                if(nombreProducto == p.Nombre && categoria == p.Ambito)
                {
                    if (p.Stock > 0)
                    {
                        sb.AppendLine($"{p.ToString()}");
                        break;
                    }
                    else
                    {
                        sb.AppendLine("No hay Stock");
                        break;
                    }
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// recorre la lista de stock y muestra cada uno de sus productos 
        /// </summary>
        /// <returns></returns>
       public string MostrarInventario()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Producto p in this.productos)
            {
                sb.AppendLine(p.ToString());
            }
            return sb.ToString();
        }

        


    }
}
