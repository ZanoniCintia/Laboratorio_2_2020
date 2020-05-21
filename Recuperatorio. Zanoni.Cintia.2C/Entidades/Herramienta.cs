using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Herramienta:Producto
    {
        
        private TipoHerramientas tipo;


        /// <summary>
        /// propiedad abstracta implementada , retorna el 16% del precio del producto
        /// invoca propiedad precio de producto
        /// </summary>
        public override double CalcularMargenGanancias
        {
            get
            {
                return (this.Precio * 16) / 100;
            }
        }

        /// <summary>
        /// propiedad solo lectura retorna tipo enumerado de la clase
        /// </summary>
        public TipoHerramientas TipoHerramienta
        {
            get
            {
                return this.tipo;
            }
        }

        /// <summary>
        ///  constructo inicializa campos de la clase, invoca el constructor base
        ///  inicializa el tipo
        /// </summary>
        /// <param name="tipo"></param>
        /// <param name="nombre"></param>
        /// <param name="codigo"></param>
        /// <param name="precio"></param>
        /// <param name="stock"></param>
        /// <param name="ambito"></param>
        /// <param name="usuario"></param>
        public Herramienta(TipoHerramientas tipo, string nombre, int codigo, double precio, int stock, TipoDeAmbito ambito, TipoDeUsuario usuario)
           : base(nombre,codigo, precio, stock, ambito, usuario)
        {
            this.tipo = tipo;
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
                case TipoHerramientas.Taladro:
                    sb.AppendLine("Colocar la mecha de la medida deseada");
                    sb.AppendLine("Enroscar el cabezal hasta trabar la mecha");
                    sb.AppendLine("Conectar a corriente electrica 220wts");
                    break;
                case TipoHerramientas.Sierra:
                    sb.AppendLine("Colocar medida deseada de la hoja");
                    sb.AppendLine("Ajustar con la rosca de los laterales hasta que quede firme");
                    sb.AppendLine("Proceder al corte, apta a cualquier tipo de madera");
               
                    break;
                case TipoHerramientas.Lijadora:
                    sb.AppendLine("Colocar el papel de lija del grosor deseado");
                    sb.AppendLine("Ajustar con la rosca plastica azul trasera");
                    sb.AppendLine("Conectar a corriente electrica a 220 wts");
                    sb.AppendLine("Encender con el boton rojo en modo on");
                    sb.AppendLine("Aplicar presion al lijar la superficia elejida");
                    break;
                case TipoHerramientas.Amoladora:
                    sb.AppendLine("Colocar en el eje superior el disco deseado");
                    sb.AppendLine("Ajustar enroscando con la llave incluida en el Kit");
                    sb.AppendLine("Colocar el protector plastico antes de proceder al corte");
                    sb.AppendLine("Conectar a corriente electrica a 220wts");
                    sb.AppendLine("Encender colocando la perilla plastica de encendido en el nivel deseado");

                    break;

            }
            return sb.ToString();
        }

        /// <summary>
        /// sobrecarga toString con los datos de la clase, invoca el metodo de clase base
        /// agrega el tipo de producto 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"-{TipoHerramienta}- "); 

            sb.AppendLine(base.ToString());
            switch (tipo)
            {
                case TipoHerramientas.Taladro:
                    sb.AppendLine($"Taladro alta resistencia Industria Argentina");
                    break;
                case TipoHerramientas.Sierra:
                    sb.AppendLine($"Sierra metalica manual");
                    break;
                case TipoHerramientas.Lijadora:
                    sb.AppendLine($"Lijadora Electrica alta resistencia");
                    break;
                case TipoHerramientas.Amoladora:
                    sb.AppendLine($"Amoladora con kit de discos y llaves de ajuste");
                    break;
            }

            return sb.ToString();
        }

        /// <summary>
        /// enumerado
        /// </summary>
        public enum TipoHerramientas
        {
            Taladro,
            Sierra,
            Lijadora,
            Amoladora
        }
    }
}
