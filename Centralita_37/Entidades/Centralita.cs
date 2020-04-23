using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();

        }
        public Centralita(string NombreEmpresa):this()
        {
            this.razonSocial = NombreEmpresa;
        }

        public float GananciaPorLocal
        {
            get { return CalcularGanancia(Llamada.TipoLlamada.Local) ; }
            
        }

        public float GananciaPorProvincial
        {
            get { return CalcularGanancia(Llamada.TipoLlamada.Provincial); }
        }

        public float GananciaPorTotal
        {
            get { return CalcularGanancia(Llamada.TipoLlamada.Todas); }
        }
        public List<Llamada> Llamadas
        {
            get { return this.listaDeLlamadas; }
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float auxGanancias = 0;

            foreach (Llamada llamada in listaDeLlamadas)
            {
                if (tipo == Llamada.TipoLlamada.Local || tipo == Llamada.TipoLlamada.Todas && llamada is Local)
                {
                    auxGanancias = auxGanancias + ((Local)llamada).CostoLlamada;
                
                }
                else if (tipo == Llamada.TipoLlamada.Provincial || tipo == Llamada.TipoLlamada.Todas && llamada is Provincial)
                {
                    auxGanancias = auxGanancias + ((Provincial)llamada).CostoLlamada;
                }
            }
            return auxGanancias;

        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            string aux = "";
            sb.AppendLine("Razon social: "+razonSocial);
            sb.AppendLine("Ganancia total: "+GananciaPorTotal);
            foreach (Llamada llamada in listaDeLlamadas)
            {
                if(llamada is Local)
                {
                    aux = ((Local)llamada).Mostrar();
                }else if(llamada is Provincial)
                {
                    aux = ((Provincial)llamada).Mostrar();
                }
                sb.AppendLine(aux);
            }

            return sb.ToString();
        }
    }
}
