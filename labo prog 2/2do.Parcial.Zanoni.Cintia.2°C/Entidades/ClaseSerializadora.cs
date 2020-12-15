using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Entidades
{
    public static class ClaseSerializadora
    {
        public static void GuardarXml<T>(string ruta, T objeto)
        {
            using (XmlTextWriter w = new XmlTextWriter(ruta, Encoding.UTF8))
            {
                XmlSerializer serializar = new XmlSerializer(typeof(T));
                serializar.Serialize(w, objeto);
            }
        }

        public static void LeerXml<T>(string ruta, T objeto)
        {
            using (XmlTextReader r = new XmlTextReader(ruta))
            {

                XmlSerializer serializar = new XmlSerializer(typeof(T));
                objeto = (T)serializar.Deserialize(r);
            }
        }
    }
}
