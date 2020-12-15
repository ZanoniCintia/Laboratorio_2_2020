using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pacientes:Persona
    {
        public enum Cobertura { CoberturaBasica,CoberturaCompleta,Notiene}
        private Cobertura tipoCobertura;

        public Cobertura TipoCobertura
        {
            get { return this.tipoCobertura; }
            set { this.tipoCobertura = value; }
        }

        public Pacientes()
            : base()
        {

        }
        public Pacientes(int id,string nombre, string apellido,int edad,string sexo, string direccion,Cobertura tipoCobertura)
            : base(id,nombre,apellido,edad,sexo,direccion)
        {
            this.tipoCobertura = tipoCobertura;
        }

        public static bool operator ==(Pacientes p1,Pacientes p2)
        {
            return p1.ID == p2.ID && p1.Apellido == p2.Apellido;

        }

        public static bool operator !=(Pacientes p1,Pacientes p2)
        {
            return !(p1 == p2);
        }
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Cobertura : {this.tipoCobertura}");
            return sb.ToString();
        }

    }
}
