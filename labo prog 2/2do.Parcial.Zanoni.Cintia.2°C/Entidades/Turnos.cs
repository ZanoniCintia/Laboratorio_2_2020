using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Turnos
    {
        private int idTurno;
        private int idPaciente;
        private int idEspecialista;
        private string observaciones;
        private DateTime fecha;

        #region Propiedades
        public int IDTurno
        {
            get { return this.idTurno; }
            set { this.idTurno = value; }
        }
        public int IDPaciente
        {
            get { return this.idPaciente; }
            set { this.idPaciente = value; }
        }
        public int IDEspecialista
        {
            get { return this.idEspecialista; }
            set { this.idEspecialista = value; }
        }
        public string Observaciones
        {
            get { return this.observaciones; }
            set { this.observaciones = value; }
        }
        public DateTime Fecha
        {
            get { return this.fecha; }
            set { this.fecha = value; }
        } 
        #endregion

        public Turnos(int idTurno, int idPaciente, int idEspecialista, string observaciones, DateTime fecha)
        {
            this.idTurno = idTurno;
            this.idPaciente = idPaciente;
            this.idEspecialista = idEspecialista;
            this.observaciones = observaciones;
            this.fecha = fecha;
        }

        public Turnos()
        {

        }

        public static bool operator ==(Turnos t1, Turnos t2)
        {
            return t1.idTurno == t2.idTurno && t1.fecha == t2.fecha;
        }
        public static bool operator !=(Turnos t1, Turnos t2)
        {
            return !(t1 == t2);
        }

    }
}
