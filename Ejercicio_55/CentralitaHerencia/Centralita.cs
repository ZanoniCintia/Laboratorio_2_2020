using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
#pragma warning disable CS0660, CS0661
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();

        }
        public Centralita(string NombreEmpresa) : this()
        {
            this.razonSocial = NombreEmpresa;
        }

        public float GananciaPorLocal
        {
            get { return CalcularGanancia(TipoLlamada.Local); }

        }

        public float GananciaPorProvincial
        {
            get { return CalcularGanancia(TipoLlamada.Provincial); }
        }

        public float GananciaPorTotal
        {
            get { return CalcularGanancia(TipoLlamada.Todas); }
        }
        public List<Llamada> Llamadas
        {
            get { return this.listaDeLlamadas; }
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            
             float totalLocal = 0;
            float totalProvincial = 0;

            foreach (Llamada llamada in this.Llamadas)
            {
                if (llamada is Local)
                    totalLocal += ((Local)llamada).CostoLlamada;
                if (llamada is Provincial)
                    totalProvincial += ((Provincial)llamada).CostoLlamada;
            }
            
            switch (tipo)
            {
                case TipoLlamada.Local:
                    return totalLocal;
                case TipoLlamada.Provincial:
                    return totalProvincial;
                case TipoLlamada.Todas:
                    return totalLocal + totalProvincial;
                default:
                    return 0;
            }

        }

        private void AgregarLLamada(Llamada nuevaLlamada)
        {
            listaDeLlamadas.Add(nuevaLlamada);

        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        } 

        public static bool operator ==(Centralita c, Llamada llamada)
        {
            bool retorno = false;
            if(!(c is null) && !(llamada is null))
            {
                foreach (Llamada aux in c.listaDeLlamadas)
                {
                    if (aux == llamada)
                    {
                        retorno = true;
                    }
                }
            }
           
            return retorno;
        }

        public static bool operator !=(Centralita c , Llamada llamada)
        {
            return !(c == llamada);
        }

        public static Centralita operator +(Centralita c,Llamada nuevaLlamada)
        {
            Centralita retorno = c;
            if (c != nuevaLlamada)
            {
                c.AgregarLLamada(nuevaLlamada);
                retorno = c;
            }
            else
            {
                throw new CentralitaException("Llamada ya registrada ", "Clase centralita", "Operador +");
            }
            return retorno;
                   
        }

        public override string ToString()
        {///ganancia revisar
            StringBuilder sb = new StringBuilder();
            string aux = "";
            sb.AppendLine("Razon social: " + razonSocial);
            sb.AppendLine("Ganancia total: " + GananciaPorTotal);
            foreach (Llamada llamada in listaDeLlamadas)
            {
                if (llamada is Local)
                {
                    aux = ((Local)llamada).ToString();
                }
                else if (llamada is Provincial)
                {
                    aux = ((Provincial)llamada).ToString();
                }
                sb.AppendLine(aux);
            }

            return sb.ToString();
        }
    }
}
