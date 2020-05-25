using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;
        private string nombre;


        /// <summary>
        /// propiedad del atributo apellido de lectura y escritura
        /// valida que se ingresen caracteres validos para apellidos
        /// </summary>
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        /// <summary>
        /// propiedad del atributo dni de lectura y escritura
        /// valida tipo y cantidad de caracteres segun nacionalidad
        /// Nacionalidad Argentina entre 1 y 89999999
        /// Extranjero entre 90000000 y 99999999
        /// </summary>
        public int DNI
        {
            get { return this.dni; }
            set { this.dni = value; }
        }

        /// <summary>
        /// propiedad del atributo nacionalidad de lectura y escritura
        /// </summary>
        public ENacionalidad Nacionalidad
        {
            get { return this.nacionalidad; }
            set { this.nacionalidad = value; }
        }

        /// <summary>
        /// propiedad del atributo nombre de lectura y escritura
        /// valida que se ingresen caracteres validos para nombre
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        /// <summary>
        /// propiedad stringToDni de solo escritura
        /// 
        /// </summary>
        public string StringToDni
        {
            set { }// myVar = value; }
        }

        public Persona()
        {

        }
    


        /// <summary>
        /// Enumerado
        /// </summary>
        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }
    }
}
