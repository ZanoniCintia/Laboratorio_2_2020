using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Iluminacion:Producto
    {
        private string colorFoco;
        private double altura;
        private TipoIluminaria tipo;
        private Producto ganancia;

        /// <summary>
        /// propiedad abstracta implementada , retorna el 10% del precio del producto
        /// </summary>
        public override double CalcularMargenGanancias
        {
            get
            { 
                return (ganancia.Precio * 10)/100;
            }
        }

        /// <summary>
        /// propiedad solo lectura retorna string con color de foco
        /// </summary>
        public string ColorFoco
        {
            get
            {
                return this.colorFoco;
            }
        }

        /// <summary>
        /// propiedad solo lectura retorna tipo enumerado de clase
        /// </summary>
        public TipoIluminaria TipoIluminacion
        {
            get
            {
                return this.tipo;
            }
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
                case TipoIluminaria.Focos:
                    sb.AppendLine("Innovador sistema bajo consumo");
                    sb.AppendLine("Enroscar a portalamparas a 220wts");
                    
                    break;
                case TipoIluminaria.LamparasPie:
                    sb.AppendLine("Altura regulable");
                    sb.AppendLine("Armar la base de madera y enroscar el portalamparas metalico");
                    sb.AppendLine("Conectar el regulador de intensidad de luz en la base plastica");
                    sb.AppendLine("Conectar a 220wts");
                    
                    break;
                case TipoIluminaria.ApliqueInterior:
                    sb.AppendLine("Cortar la corriente electrica");
                    sb.AppendLine("Embutir el aplique en la zona que desea con los tornillos m5");
                    sb.AppendLine("Empalmar los cables positivo(rojo) y negativo(negro)");
                    sb.AppendLine("Dar corriente electrica a 220wts");
                    break;
                case TipoIluminaria.ApliqueExterior:
                    sb.AppendLine("Cortar la corriente electrica");
                    sb.AppendLine("Embutir el aplique en la zona que desea con los tornillos m5");
                    sb.AppendLine("Empalmar los cables positivo(rojo) y negativo(negro)");
                    sb.AppendLine("Dar corriente electrica a 220wts");
                    sb.AppendLine("Resistente al agua");
                    break;

            }
            return sb.ToString();
        }


        /// <summary>
        ///  constructo inicializa campos de la clase, invoca el constructor base
        /// </summary>
        /// <param name="tipo"></param>
        /// <param name="nombre"></param>
        /// <param name="codigo"></param>
        /// <param name="precio"></param>
        /// <param name="stock"></param>
        /// <param name="color"></param>
        /// <param name="ambito"></param>
        /// <param name="usuario"></param>
        public Iluminacion(TipoIluminaria tipo,string nombre,int codigo, double precio, int stock,string color, TipoDeAmbito ambito, TipoDeUsuario usuario)
            : base(nombre,codigo, precio, stock, ambito, usuario)
        {
            this.tipo = tipo;
            this.colorFoco = color;
        }


        /// <summary>
        /// sobrecarga toString con los datos de la clase, invoca el metodo de clase base
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            switch (tipo)
            {
                case TipoIluminaria.Focos:
                    sb.AppendLine($"Color : {this.colorFoco}");
                    break;
                case TipoIluminaria.LamparasPie:
                    sb.AppendLine($"Altura : {this.altura}");
                    break;
                case TipoIluminaria.ApliqueInterior:
                    sb.AppendLine($"Estructura plastica revestimiento en madera");
                    break;
                case TipoIluminaria.ApliqueExterior:
                    sb.AppendLine($"Estructura plastica revestimiento metalico");
                    break;
            }
            
            return sb.ToString();
        }

        /// <summary>
        /// enumerado
        /// </summary>
        public enum TipoIluminaria
        {
            LamparasPie,
            Focos,
            ApliqueExterior,
            ApliqueInterior
            
        }




    }
}
