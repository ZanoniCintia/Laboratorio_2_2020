using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        private string nombre;
        private int codigo;
        private double precio;
        private int stock;
        private TipoDeAmbito ambito;
        private TipoDeUsuario usuario;

        /// <summary>
        /// Propiedad de solo lectura retorna un enumerado tipo ambito
        /// </summary>
        public TipoDeAmbito Ambito
        {
            get { return this.ambito; }
            
        }

        /// <summary>
        /// Propiedad de solo lectura retorna un enumerado tipo usuario 
        /// </summary>
        public TipoDeUsuario Usuario
        {
            get { return this.usuario; }

        }

        /// <summary>
        /// Propiedad de solo lectura retorna un double con el precio
        /// </summary>
        public double Precio
        {
            get { return this.precio; }

        }

        /// <summary>
        /// propiedad de solo lectura retorna un string con el nombre
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }

        }



        /// <summary>
        /// propiedad de lectura y escritura retorna int, evalua si el stock contiene elementos
        /// </summary>
        public int Stock
        {
            get 
            {     
                return this.stock;
            }
            set
            {
                if(value >= 0)
                {
                    this.stock = value;
                }
            }

        }

        /// <summary>
        /// prpiedad solo lectura retorna int con el codigo
        /// </summary>
        public int Codigo
        {
            get { return this.codigo; }

        }

        /// <summary>
        /// propiedad abstracta de solo lectura
        /// </summary>
        public abstract double CalcularMargenGanancias { get; }

        
        /// <summary>
        /// constructor de clase publico
        /// </summary>
        public Producto()
        {

        }

        /// <summary>
        /// construstor de clase con parametros, inicializa elementos de la clase
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="codigo"></param>
        /// <param name="precio"></param>
        /// <param name="stock"></param>
        /// <param name="ambito"></param>
        /// <param name="usuario"></param>
        public Producto(string nombre,int codigo,double precio,int stock,TipoDeAmbito ambito,TipoDeUsuario usuario)
        {
            this.nombre = nombre;
            this.codigo = codigo;
            this.precio = precio;
            this.stock = stock;
            this.usuario = usuario;
            this.ambito = ambito;
        }

        /// <summary>
        /// Metodo abstracto a implementar en clases derivadas, retorna string
        /// </summary>
        /// <returns></returns>
        public abstract string InstruccionesDeUso();

        /// <summary>
        /// sobrecarga de metodo toString con los datos de la clase
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            //sb.AppendLine($"Ambito: {this.Ambito}");
            //sb.AppendLine($"Usuario : {this.Usuario}");
            sb.AppendLine($"Codigo : {this.Codigo}");
            sb.AppendLine($"Precio : {this.Precio}");
            sb.AppendLine($"Stock : {this.Stock}");

            return sb.ToString();

        }

        /// <summary>
        /// sobrecarga operadot ==, dos productos son iguales si comparten mismo codigo y nombre
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator ==(Producto p1, Producto p2)
        {
            return p1.Codigo == p2.Codigo && p1.Nombre == p2.Nombre;
        }

        /// <summary>
        /// sobrecarga operador != , reutiliza codigo ==
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
    }
}
