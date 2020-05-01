using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Planeta:Astro
    {
        private int cantSatelites;
        private Tipo tipo;
        private List<Astro> satelites;

        public Planeta(int duraOrbita,int duraRot,string nombre,int cantSatelites,Tipo tipo)
            :this(duraOrbita,duraRot,nombre)
        {   
            
            this.cantSatelites = cantSatelites;
            this.tipo = tipo;
            if (cantSatelites >0)
            {
                satelites = new List<Astro>();
            }
            
        }

        public Planeta(int duraOrbita, int duraRot,string nombre):base(duraOrbita,duraRot,nombre)
        {

        }

        public List<Astro> Satelite
        {
            get { return this.satelites; }
        }

        public override string Orbitar()
        {
            return string.Format($"Orbita el planeta: {this.nombre}");
        }

        public new string Rotar()
        {
            return string.Format($"Orbita el planeta: {this.nombre}");
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostar());
            sb.AppendLine($"Cantidad de satelites :{this.cantSatelites}");
            sb.AppendLine($"Es de tipo: {this.tipo}");
            if(!(satelites is null))
            {
                foreach (Satelite auxSatelites in satelites)
                {
                    sb.AppendLine(auxSatelites.ToString());
                }
            }
           
            return sb.ToString();
        }

        public static bool operator ==(Planeta planeta,Planeta planeta2)
        {
            return (planeta.nombre == planeta2.nombre);
        }
        public static bool operator !=(Planeta planeta, Planeta planeta2)
        {
            return !(planeta == planeta2);
        }

        public static bool operator ==(Planeta planeta, Satelite satelite)
        {
            bool retorno = false;
            foreach (Satelite auxSatelite in planeta.satelites)
            {
                if (auxSatelite.Nombre == satelite.Nombre)
                {
                    retorno = true;
                }
                break;
            }
            return retorno;
        }

        public static bool operator !=(Planeta planeta,Satelite satelite)
        {
            return !(planeta == satelite);
        }

        public static bool operator +(Planeta planeta,Astro astro)
        {
            bool retorno = false;
            if(!(astro is null) && !(planeta is null))
            {   
                if(astro is Satelite && planeta.Satelite.Count < planeta.cantSatelites)
                {
                    planeta.Satelite.Add(astro);
                    retorno = true;
                }
 
            }
            return retorno;

        }

    }
}
