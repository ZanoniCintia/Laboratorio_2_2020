using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadCompetidores, short cantidadVueltas):this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cantidad de competidores: {this.cantidadCompetidores}");
            sb.AppendLine($"Cantidad de vueltas: {this.cantidadVueltas}");
            foreach (AutoF1 aux in competidores)
            {
                sb.AppendLine(aux.MostrarDatos());
            }
            return sb.ToString();
        }
        public static bool operator ==(Competencia c,AutoF1 a)
        {
            bool retorno = false;
            foreach (AutoF1 aux in c.competidores)
            {
                if (aux == a)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Competencia c,AutoF1 a)
        {
            return !(c == a);
        }
        public static bool operator +(Competencia c,AutoF1 a)
        {
            bool retorno = false;
            Random aleatorio = new Random();
            if(!(c is null) && !(a is null))
            {
                if(c.competidores.Count < c.cantidadCompetidores && c!=a)
                {
                        c.competidores.Add(a);
                        a.EnCompetencia = true;
                        a.VueltasRestantes = c.cantidadVueltas;
                        a.CantidadCombustible = (short)aleatorio.Next(15,100);
                        retorno = true;
                }
       
            }
            return retorno;
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            bool retorno = false;
            if (!(c is null) && !(a is null))
            {
                if (c == a)
                {
                    c.competidores.Remove(a);
                    a.CantidadCombustible = 0;
                    a.EnCompetencia = false;
                    a.VueltasRestantes = 0;
                    retorno = true;
                }
            }
            return retorno;
            
        }
    }
}
