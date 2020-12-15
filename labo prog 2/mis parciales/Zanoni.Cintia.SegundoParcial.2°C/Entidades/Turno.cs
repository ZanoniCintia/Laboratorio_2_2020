using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{   
    [Serializable]
    public class Turno
    {
        private int idTurno;
        private int idPaciente;
        private int idEspecialista;
        private string observacion;
        private string fecha;
        


        #region Propiedades
        /// <summary>
        /// propiedad int Id
        /// </summary>
        public int IdTurno
        {
            get { return this.idTurno; }
            set { this.idTurno = value; }
        }

        /// <summary>
        /// propiedad int IdPaciente
        /// </summary>
        public int IdPaciente
        {
            get { return this.idPaciente; }
            set { this.idPaciente = value; }
        }

        /// <summary>
        /// propiedad int IdEspecialista
        /// </summary>
        public int IdEspecialista
        {
            get { return this.idEspecialista; }
            set { this.idEspecialista = value; }
        }

        /// <summary>
        /// propiedad string observacion
        /// </summary>
        public string Observacion
        {
            get { return this.observacion; }
            set { this.observacion = value; }
        }

        /// <summary>
        /// propiedad string fecha
        /// </summary>
        public string Fecha
        {
            get { return this.fecha; }
            set { this.fecha = value; }
        }

  

     

        #endregion

        #region Constructores

        /// <summary>
        /// constructor publico con parametros
        /// </summary>
        /// <param name="idPaciente"></param>
        /// <param name="idEspecialista"></param>
        /// <param name="observacion"></param>
        /// <param name="fecha"></param>
        public Turno( int idPaciente, int idEspecialista, string observacion, string fecha)
        {
           
            this.idPaciente = idPaciente;
            this.idEspecialista = idEspecialista;
            this.observacion = observacion;
            this.fecha = fecha;
            
        }

        /// <summary>
        /// constructor publico sin parametros
        /// </summary>
        public Turno() { }
        #endregion

        #region Operadores
        /// <summary>
        /// operador ==
        /// dos turnos son iguales si su id y el del paciente son iguales
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public static bool operator ==(Turno t1, Turno t2)
        {
            return t1.idTurno == t2.idTurno && t1.idPaciente == t2.idPaciente;
        }

        /// <summary>
        /// operador !=
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public static bool operator !=(Turno t1, Turno t2)
        {
            return !(t1 == t2);
        }
        #endregion

        #region Metodos

       

        /// <summary>
        /// sobrecarga de toString muestra datos del turno
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(String.Format(" ----------------------"));
            sb.Append(String.Format(" IdPaciente: {0}", this.IdPaciente));
            sb.Append(String.Format(" Idprofesional: {0}", this.IdEspecialista));
            sb.Append(String.Format(" Fecha: {0} ", this.Fecha));
            sb.AppendLine(String.Format(" ----------------------"));

            return sb.ToString();
        }


        #endregion

       



    }
   
}
