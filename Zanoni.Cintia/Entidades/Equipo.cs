using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private const int cantidadMaxima=6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;

        public DirectorTecnico DirectorTecnico
        {
            set 
            {  
                if(value.ValidarAptitud())
                {
                    this.directorTecnico = value;
                    
                }

            }
           
        }
        public string Nombre
        {
            get { return this.nombre;}
        }

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }
        
        public Equipo(string nombre):this()
        {
            this.nombre = nombre;
        }

        public static explicit operator string(Equipo a)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre del equipo: {a.Nombre}");
            sb.AppendLine($"Director tecnico: ");
            if(a.directorTecnico != null)
            {
                sb.AppendLine(a.directorTecnico.Mostrar());
            }
            else { sb.AppendLine("Sin DT asignado"); }

            sb.AppendLine("Lista de Jugadores:");
            foreach (Jugador auxJugador in a.jugadores)
            {
                sb.AppendLine(auxJugador.Mostrar());
               
                
            }
            return sb.ToString();
            
        }
        public static bool operator ==(Equipo e , Jugador j)
        {
            bool retorno = false;
            foreach (Jugador auxJugador in e.jugadores)
            {
                if (auxJugador == j)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }
        public static Equipo operator +(Equipo e, Jugador j)
        {
           
                if (e.jugadores.Count < Equipo.cantidadMaxima && j.ValidarAptitud() && e != j)
                {
                    e.jugadores.Add(j);
                }
           
            return e;
        }

        public static bool ValidarEquipo(Equipo e)
        {
            bool retorno = false;
            int cantidadArqueros = 0;
            int cantidadDefensores = 0;
            int cantidadCentrales = 0;
            int cantidadDelanteros = 0;
            if (e.directorTecnico != null)
            {
                foreach (Jugador jugador in e.jugadores)
                {
                    switch (jugador.Posicion)
                    {
                        case Posicion.Arquero:
                            cantidadArqueros++;
                            break;
                        case Posicion.Defensor:
                            cantidadDefensores++;
                            break;
                        case Posicion.Central:
                            cantidadCentrales++;
                            break;
                        case Posicion.Delantero:
                            cantidadDelanteros++;
                            break;
                    }
                }
                if (e.jugadores.Count == cantidadMaxima)
                {
                    if (cantidadArqueros == 1 && cantidadCentrales > 0 && cantidadDefensores > 0 && cantidadDelanteros > 0)
                    {
                        retorno= true;
                    }
                }
            }
            return retorno;
        }

    }



}

