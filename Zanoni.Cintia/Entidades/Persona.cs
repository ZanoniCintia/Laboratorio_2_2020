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
        private int edad;
        private string nombre;

        protected Persona(string nombre,string apellido, int edad, int dni)
        {
            this.apellido = apellido;
            this.dni = dni;
            this.edad = edad;
            this.nombre = nombre;
        }

        public string Apellido
        {
            get { return this.apellido; }

        }
        public int Dni
        {
            get { return this.dni; }

        }
        public int Edad
        {
            get { return this.edad; }
        }

        public string Nombre
        {
            get { return this.nombre; }
        }
        public abstract bool ValidarAptitud();
    
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre :{this.Nombre}");
            sb.AppendLine($"Apellido :{this.Apellido}");
            sb.AppendLine($"Edad :{this.Edad}");
            sb.AppendLine($"DNI :{this.Dni}");
            return sb.ToString();
        }
    }
}
