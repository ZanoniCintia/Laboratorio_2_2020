using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private int espacioDisponible;
        private string nombre;
        private List<Vehiculo> vehiculos;

        public Estacionamiento( string nombre, int espacioDisponible)
            :this()
        {
            this.espacioDisponible = espacioDisponible;
            this.nombre = nombre;
        }
        private Estacionamiento()
        {
            vehiculos = new List<Vehiculo>();
        }

        public static explicit operator string(Estacionamiento e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Estacionamiento {e.nombre}");
            sb.AppendLine($"Espacios disponibles: {e.espacioDisponible}");
            sb.AppendLine($"Ingresos:");
            foreach (Vehiculo auxVehiculo in e.vehiculos)
            {
                sb.AppendLine(auxVehiculo.ConsultarDatos());
            }

            return sb.ToString();
        }

        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
             bool retorno = false;
             foreach (Vehiculo auxVehiculo in estacionamiento.vehiculos)
             {
                 if (auxVehiculo == vehiculo)
                 {
                     retorno = true;
                 }
             }
             return retorno;

            
        }
        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return !(estacionamiento == vehiculo);
        }

        public static Estacionamiento operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if (estacionamiento != vehiculo && vehiculo.Patente != ""
                &&  estacionamiento.vehiculos.Count < estacionamiento.espacioDisponible)
            {
                estacionamiento.vehiculos.Add(vehiculo);
            }
            return estacionamiento;
        }

        public static string operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            string retorno = "";
            if(estacionamiento == vehiculo)
            {
                estacionamiento.vehiculos.Remove(vehiculo);
                retorno = vehiculo.ImprimirTicket();
            }
            else
            {
                retorno="El vehiculo no es parte del estacionamiento";
            }
            return retorno;
            
        }



    }
}
