using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Especialista : Persona
    {   
        
        
        private Especialidad tipoEspecialidad;

        /// <summary>
        /// propiedad de Campo especialidad
        /// </summary>
        public Especialidad Campo
        {
            get { return this.tipoEspecialidad; }
            set { this.tipoEspecialidad = value; }
        }


        /// <summary>
        /// constructor publico sin parametros , invoca al de la clase base
        /// </summary>
        public Especialista()
            :base()
        {

        }

        /// <summary>
        /// constructor publico con parametros
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="sexo"></param>
        /// <param name="direccion"></param>
        /// <param name="tipoE"></param>
        public Especialista(int id, string nombre, string apellido, int edad, string sexo, string direccion, Especialidad tipoE)
            : base(id, nombre, apellido, edad, sexo, direccion)
        {
            this.tipoEspecialidad = tipoE;

        }

      /// <summary>
      /// metodo que retorna estring con el nombre y la especialidad 
      /// </summary>
      /// <returns></returns>
        public  string DatosEspecialista()
        {
            return this.Nombre + " " + this.tipoEspecialidad;
        }

        /// <summary>
        /// sobrecarga de toString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Nombre;
        }
    }

    /// <summary>
    /// enumerado
    /// </summary>
    public enum Especialidad { Pediatra, ClinicaGeneral, Psicologia, Obstetricia, Dermatologia, Otorrinolaringologia, Ginecologia, Odontologia, Oftalmologia }

}