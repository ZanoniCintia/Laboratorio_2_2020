using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;


namespace Entidades
{
    public static class ExtencionDateTime
    {   
        /// <summary>
        /// metodo de extension convierte un dateTime en string con un formato
        /// </summary>
        /// <param name="fecha"></param>
        /// <returns></returns>
        public static string FormatearFecha(this DateTime fecha)
        {
            
            return fecha.ToString("MM_dd_yyyy_HH_mm_ss");
        }


        public static bool SerializarBinario(this Turno turno,string path)
        {
            bool retorno = false;
            using (Stream stream= new FileStream(path, FileMode.Create))
            {
                BinaryFormatter serializar = new BinaryFormatter();
                serializar.Serialize(stream, turno);
                retorno = true;
            }
            return retorno;
        }
    }
}
