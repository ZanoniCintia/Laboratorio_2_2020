using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Paciente : Persona
    {   
        
      
        private Cobertura tipoCobertura;
       

        #region Propiedades

        /// <summary>
        /// propiedad Tipo de cobertura
        /// </summary>
        public Cobertura TipoCobertura
        {
            get { return this.tipoCobertura; }
            set { this.tipoCobertura = value; }
        }

      
        #endregion

        #region Metodos

        /// <summary>
        /// constructor publico sin parametros 
        /// invoca al de la clase base
        /// </summary>
        public Paciente()
            :base()
        {

        }

        /// <summary>
        /// constructor con parametros
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="sexo"></param>
        /// <param name="direccion"></param>
        /// <param name="tipoCobertura"></param>
        public Paciente(int id, string nombre, string apellido, int edad, string sexo, string direccion, Cobertura tipoCobertura)
            : base(id, nombre, apellido, edad, sexo, direccion)
        {
            this.tipoCobertura = tipoCobertura;

        }

       /// <summary>
       /// devuelve string con nombre y apellido
       /// </summary>
       /// <returns></returns>
        public  string DatosPaciente()
        {
            
            return this.Nombre + " " + this.Apellido;
        }


        /// <summary>
        /// sobrecarga de toString retorna nombre 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Nombre;
        }
        #endregion


    }

    /// <summary>
    /// enumerado
    /// </summary>
    public enum Cobertura { CoberturaBasica, CoberturaCompleta, Notiene }
   

}