using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Especialistas:Persona
    {
        public enum Especialidad { Pediatra,ClinicaGeneral,Psicologia,Obstetricia,Dermatologia,Otorrino,Ginecologia }
        private Especialidad tipoEspecialidad;

        
        public Especialidad TipoEspecialidad
        {
            get { return this.tipoEspecialidad; }
            set { this.tipoEspecialidad = value; }
        }

        public Especialistas()
            : base()
        {

        }
        public Especialistas(int id,string nombre,string apellido, int edad,string sexo,string direccion,Especialidad tipoE )
            : base(id,nombre,apellido,edad,sexo,direccion)
        {
            this.tipoEspecialidad = tipoE;

        }

        public static bool operator ==(Especialistas e1, Especialistas e2)
        {
            return e1.ID == e2.ID && e1.tipoEspecialidad == e2.tipoEspecialidad;
        }

        public static bool operator !=(Especialistas e1, Especialistas e2)
        {
            return !(e1 == e2);
        }
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Especilidad : {this.TipoEspecialidad}");
            return base.MostrarDatos();
        }
    }
}
