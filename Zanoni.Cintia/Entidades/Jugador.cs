using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador:Persona
    {
        private float altura;
        private float peso;
        private Posicion posicion;

        
        public float Altura
        {
            get { return this.altura; }
           
        }
        public float Peso
        {
            get { return this.peso; }
          
        }
        public Posicion Posicion
        {
            get { return this.posicion; }
            
        }

        public Jugador(string nombre,string apellido,int edad,int dni,float peso,float altura,Posicion posicion)
            : base(nombre, apellido, edad, dni)
        {
            this.altura = altura;
            this.peso = peso;
            this.posicion = posicion;
        }

        public override bool ValidarAptitud()
        {
            return (Edad <= 40 && ValidarEstadoFisico());
        }

        public bool ValidarEstadoFisico()
        {
            
            float imc =((float) peso / (altura*altura));
            return (imc >= 18.5f && imc <= 25);

        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Altura :{this.Altura}");
            sb.AppendLine($"Peso :{this.Peso}");
            sb.AppendLine($"Posicion :{this.Posicion}");
            return sb.ToString();
        }

    }
}
