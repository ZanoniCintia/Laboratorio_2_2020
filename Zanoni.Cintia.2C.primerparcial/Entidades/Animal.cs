using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Animal
    {
        private int kilosAlimento;
        private string nombre;
        /// <summary>
        /// propiedades abstractas a implementar en clases derivadas
        /// </summary>
        public abstract bool ComeBalanceado { get; }
        public abstract bool ComePasto { get; }
        
        /// <summary>
        /// propiedad retorna int con el campo KilosAlimento
        /// </summary>
        public int KilosAlimento
        {
            get
            {
                return this.kilosAlimento;
            }
        }

        /// <summary>
        /// constructor inicializa campo nombre y volumen de la clase
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="volumen"></param>
        public Animal(string nombre, int volumen)
        {
            this.nombre = nombre;
            this.kilosAlimento = volumen;
            
        }

        /// <summary>
        /// metodo datos retorna un string con los datos de la clase
        /// </summary>
        /// <returns></returns>
        public string Datos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.nombre} come {this.KilosAlimento}kg");
            sb.AppendFormat($"Consume Balanceado Si/No {ComeBalanceado}");
            sb.AppendFormat($"Come pasto si/ no {ComePasto}");
            return sb.ToString();
        }
    }
}
