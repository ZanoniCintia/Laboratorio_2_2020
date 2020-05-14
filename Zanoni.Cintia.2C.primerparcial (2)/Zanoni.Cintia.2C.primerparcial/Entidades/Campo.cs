using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Campo
    {
        private int alimentoDisponible;
        private List<Animal> animales;
        private static Tipo servicio;

        public Tipo TipoServicio
        {
            set
            {
                servicio = value;
            }
        }
        private Campo()
        {
            this.animales = new List<Animal>();
        }

        static Campo()
        {
            servicio = Campo.Tipo.Engorde;
        }

        public Campo(int alimento):this()
        {
            alimentoDisponible = alimento;
        }

        private int AlimentoComprometido(Animal animal)
        {

            return animal.KilosAlimento + AlimentoComprometido();
            
        }

        private int AlimentoComprometido()
        {
            int acum=0;
            
            foreach(Animal a in this.animales)
            {

                acum += a.KilosAlimento;
            }

            return acum;
        }

        //El operador + agregará siempre y cuando disponga de alimento suficiente 
        //para agregar un  nuevo Animal(alimento disponible - kilos de alimento del Animal).

        public static bool operator +(Campo campo, Animal animal)
        {
            bool retorno = false;
           
            if(!(campo is null) && !(animal is null))
            {
                if ( campo.AlimentoComprometido(animal) <= campo.alimentoDisponible)
                {
                    campo.animales.Add(animal);
                    retorno = true;
                }
            }
            return retorno;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Servicio de campo : {Tipo.Pastoreo} {Tipo.Engorde}");
            sb.AppendLine($"Alimento comprometido {AlimentoComprometido()} de {alimentoDisponible}");
            foreach (Animal auxAnimal in animales)
            {
                sb.AppendLine(auxAnimal.Datos());
            }
            return sb.ToString();
        }


         
        public enum Tipo
        {
            Pastoreo,
            Engorde
        }
    }
}
