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
            return alimentoDisponible - animal.KilosAlimento;
        }

        private int AlimentoComprometido()
        {
            foreach (Animal auxAnimal in animales)
            {
               this.alimentoDisponible -= AlimentoComprometido(auxAnimal);
            }
            return this.alimentoDisponible;
        }

        public static bool operator +(Campo campo, Animal animal)
        {
            bool retorno = false;
            if(!(campo is null) && !(animal is null))
            {
                if (animal.KilosAlimento < campo.alimentoDisponible)
                {
                    campo.animales.Add(animal);
                    retorno = true;
                }
            }
            return retorno;
        }

        public new string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Servicio de campo : {Tipo.Pastoreo} {Tipo.Engorde}");
            sb.AppendLine($"Alimento comprometido {alimentoDisponible} de {AlimentoComprometido()}");
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
