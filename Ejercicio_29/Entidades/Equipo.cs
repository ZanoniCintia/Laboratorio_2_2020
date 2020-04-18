using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        public Equipo(short cantidadDeJugadores, string nombre):this()
        {
            this.cantidadDeJugadores = cantidadDeJugadores;
            this.nombre = nombre;
        }

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public static bool operator +(Equipo e,Jugador j)
        {
            bool retorno = false;
            if(!(e is null)&& !(j is null))
            { 
                if(e.jugadores.Count< e.cantidadDeJugadores)
                {
              
                    e.jugadores.Add(j);
                    retorno = true;
                    
                }
            }
            return retorno;
           
        }
    }
}
