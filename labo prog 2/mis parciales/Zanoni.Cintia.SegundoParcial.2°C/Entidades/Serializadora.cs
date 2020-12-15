using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace Entidades
{
    public  class Serializadora<T> :IArchivo<T>
    {   
        /// <summary>
        /// Guarda un objeto en formato xml
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="rutaDelArchivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Escribir(string archivo,string rutaDelArchivo, T datos)
        {
            bool variableRetorno = false;
            try
            {
                XmlTextWriter writer = new XmlTextWriter(rutaDelArchivo + archivo, Encoding.UTF8);
                XmlSerializer ser = new XmlSerializer(typeof(T));
                ser.Serialize(writer, datos);
                writer.Close();
                variableRetorno = true;
            }
            catch (Exception ex)
            {

            }
            return variableRetorno;


        }


        /// <summary>
        /// Lee archivos xml
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Leer(string archivo, out T datos)
        {
           
                XmlTextReader reader = new XmlTextReader(archivo);
                XmlSerializer ser = new XmlSerializer(typeof(T));
                datos = (T)ser.Deserialize(reader);
                reader.Close();
                return true;
        
        }
    
       

      
             
    }
}
