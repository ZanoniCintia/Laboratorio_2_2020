using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace Entidades
{   
    [Serializable]
  
    public abstract class Persona
    {
        private int id;
        private string apellido;
        private string nombre;
        private int edad;
        private string sexo;
        private string direccion;

       


        #region Propiedades
        /// <summary>
        /// propiedad int Id 
        /// </summary>
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        /// <summary>
        /// propiedad string nombre
        /// </summary>
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        /// <summary>
        /// propiedad string nombre
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        /// <summary>
        /// propiedad int edad 
        /// </summary>
        public int Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }

        /// <summary>
        /// propiedad string sexo
        /// </summary>
        public string Sexo
        {
            get { return this.sexo; }
            set { this.sexo = value; }
        }

        /// <summary>
        /// propiedad string Direccion 
        /// </summary>
        public string Direccion
        {
            get { return this.direccion; }
            set { this.direccion = value; }
        }
        #endregion


        #region Metodos

        /// <summary>
        /// constructor publico sin parametros
        /// </summary>
        public Persona()
        {

        }

        /// <summary>
        /// constructor publico con parametros
        /// </summary>
        /// <param name="id"></param>
        /// <param name="apellido"></param>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        /// <param name="sexo"></param>
        /// <param name="direccion"></param>
        public Persona(int id, string apellido, string nombre, int edad, string sexo, string direccion)
        {
            this.id = id;
            this.apellido = apellido;
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.direccion = direccion;
        }

     
        /// <summary>
        /// muestra los datos de una persona
        /// </summary>
        /// <returns></returns>
        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"ID: {this.id}");
            sb.AppendLine($"NOMBRE COMPLETO: {this.apellido}, {this.nombre}");
            sb.AppendFormat("\r\nEDAD: {0} \r\n", this.edad);
            sb.AppendFormat("\r\nSEXO: {0} \r\n", this.sexo);
            sb.AppendFormat("\r\nDIRECCION: {0} \r\n", this.direccion);
            return sb.ToString();
        } 
        #endregion
    }
}