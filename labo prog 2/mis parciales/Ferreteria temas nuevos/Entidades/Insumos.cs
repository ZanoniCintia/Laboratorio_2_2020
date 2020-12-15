using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Insumos:Producto
    {
       
        private TipoInsumos tipo;

        /// <summary>
        /// propiedad abstracta implementada , retorna el 13% del precio del producto
        /// invoca propiedad precio de producto
        /// </summary>
        public override double CalcularMargenGanancias
        {
            get
            {
                return (this.Precio * 13) / 100;
            }
        }

        /// <summary>
        /// propiedad retorna tipo enumerado de clase
        /// </summary>
        public TipoInsumos TipoDeInsumos
        {
            get
            {
                return this.tipo;
            }
        }

        /// <summary>
        /// constructo inicializa campos de la clase, invoca el constructor base
        /// inicializa el tipo
        /// </summary>
        /// <param name="tipo"></param>
        /// <param name="nombre"></param>
        /// <param name="codigo"></param>
        /// <param name="precio"></param>
        /// <param name="stock"></param>
        /// <param name="ambito"></param>
        /// <param name="usuario"></param>
        public Insumos(TipoInsumos tipo, string nombre, int codigo, double precio, int stock, TipoDeAmbito ambito, TipoDeUsuario usuario)
            : base(nombre,codigo, precio, stock, ambito, usuario)
        {
            this.tipo = tipo;
        }

        public Insumos()
        {

        }

        /// <summary>
        /// metodo abstracto implementado, devuelve un string con instrucciones de uso de cada tipo enumerado de la clase
        /// </summary>
        /// <returns></returns>

        public override string InstruccionesDeUso()
        {
            StringBuilder sb = new StringBuilder();
            switch (tipo)
            {
                case TipoInsumos.CintaMetrica:
                    sb.AppendLine("Quitar la traba plastica");
                    sb.AppendLine("Desenroscar a la medida deseada");
                    sb.AppendLine("Trabar activando el boton azul");
                    sb.AppendLine("Desactivar el boton y volver a poner la traba una vez terminada la medicion");
                    break;
                case TipoInsumos.Cutter:
                    sb.AppendLine("Bajar la perilla lateral");
                    sb.AppendLine("Extraer la medida deseada de la cuchilla");
                    sb.AppendLine("Guardar con la cuchilla baja y subir la perilla");
                    sb.AppendLine("Cuchillas de repuesto en la parte trasera del cutter");
                    break;
                case TipoInsumos.Guantes:
                    sb.AppendLine("Lavar con agua caliente y jabon neutro");
                    sb.AppendLine("No utilizar para manipular elementos con altas temperaturas");
                    sb.AppendLine("No aisla de la corriente electrica");
                    break;
                case TipoInsumos.Nivel:
                    sb.AppendLine("Colocar el nivel sobre la superficie a nivelar");
                    sb.AppendLine("Ubicar la burbuja del nivel en la medida deseada");     
                    break;

            }
            return sb.ToString();
        }

        /// <summary>
        /// sobrecarga toString con los datos de la clase, invoca el metodo de clase base
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"-{TipoDeInsumos}- ");

            sb.AppendLine(base.ToString());
            switch (tipo)
            {
                case TipoInsumos.CintaMetrica:
                    sb.AppendLine($"Cinta metrica metalica 2mts");
                    break;
                case TipoInsumos.Cutter:
                    sb.AppendLine($"Cutter plastico con 3 cuchillas de repuesto");
                    break;
                case TipoInsumos.Guantes:
                    sb.AppendLine($"Reforzados alta calidad");
                    break;
                case TipoInsumos.Nivel:
                    sb.AppendLine($"Nivel metalico de 35cm");
                    break;
            }

            return sb.ToString();
        }




        /// <summary>
        /// enumerado
        /// </summary>
        public enum TipoInsumos
        {
            CintaMetrica,
            Cutter,
            Guantes,
            Nivel
        }
    }
}
