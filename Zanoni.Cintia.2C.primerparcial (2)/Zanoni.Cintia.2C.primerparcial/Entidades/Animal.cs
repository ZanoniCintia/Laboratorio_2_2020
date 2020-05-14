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
        public virtual string Datos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.nombre} come {this.kilosAlimento}kg");
            if(ComeBalanceado == true)
            {
                sb.AppendLine($"Consume Balanceado Si/No : Si");
            }
            else { sb.AppendLine($"Consume Balanceado Si/No : No"); }
            
            if(ComePasto == true)
            {
                sb.AppendLine($"Consume Pasto Si/No : Si");
            }
            else { sb.AppendLine($"Consume Pasto Si/No : No"); }
            
            
            return sb.ToString();
        }
    }
}
