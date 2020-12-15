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
    [XmlInclude(typeof(Pacientes))]
    [XmlInclude(typeof(Especialistas))]
    [XmlInclude(typeof(Turnos))]
    public abstract class Persona
    {
        private int id;
        private string apellido;
        private string nombre;
        private int edad;
        private string sexo;
        private string direccion;
        
        public Persona()
        {

        }
        protected Persona(int id,string apellido, string nombre, int edad, string sexo, string direccion)
        {
            this.id = id;
            this.apellido = apellido;
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.direccion = direccion;
        }


        #region Propiedades

        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = this.ValidarNombreApellido( value); }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = this.ValidarNombreApellido(value); }
        }

        public int Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }

        public string Sexo
        {
            get { return this.sexo; }
            set { this.sexo = value; }
        }

        public string Direccion
        {
            get { return this.direccion; }
            set { this.direccion = value; }
        }
        #endregion


        /// <summary>
        /// valida que el dato ingresado por parametros de entrada sean solo letras y no se ingresen espacios en blanco 
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>

        private string ValidarNombreApellido(string dato)
        {
            string auxiliar = "";
            foreach (char letra in dato)
            {
                if (char.IsLetter(letra) && !char.IsWhiteSpace(letra))
                {
                    auxiliar = dato;
                }
            }
            return auxiliar;
        }

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



    }
}
