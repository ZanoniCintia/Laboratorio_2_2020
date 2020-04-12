using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_5
{
    #pragma warning disable CS0660, CS0661
    public class Producto
    {
        
        private string codigoDeBarras;
        private string marca;
        private float precio;

        public Producto(string marca,string codigoDeBarras, float precio)
        {
            this.codigoDeBarras = codigoDeBarras;
            this.marca = marca;
            this.precio = precio;
        }
        public string GetMarca()
        {
            return this.marca;
        }
        public float GetPrecio()
        {
            return this.precio;
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarras.ToString();
        }

        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Codigo de barras: {(string)p}");
            sb.AppendLine($"Marca: {p.GetMarca()}");
            sb.AppendLine($"Precio: {p.GetPrecio()}");

            return sb.ToString();
        }

        public static bool operator ==(Producto p,string marca)
        {
            return (p.GetMarca() == marca);
           
        }

        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
           
            return (p1.GetMarca() == p2.GetMarca() && p1.codigoDeBarras == p2.codigoDeBarras) ;
        
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

    }
}
