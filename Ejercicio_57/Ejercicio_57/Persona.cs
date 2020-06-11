using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Ejercicio_57
{
    public class Persona
    {
        public string nombre;
        public string apellido;

        public Persona()
        {

        }
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        //Serializa recibe una persona y la serializa en un archivo
        public static void Guardar(Persona persona)
        {   
            //no se como pasar la ruta
            XmlTextWriter writer = new XmlTextWriter(@"C:\Escritorio\prueba.xml", Encoding.UTF8);
            XmlSerializer ser = new XmlSerializer(typeof(Persona));
            ser.Serialize(writer, writer);
            writer.Close();
            
        }

        //deserealiza el archivo y retorna una persona
        public static Persona Leer(string path)
        {
            Persona p = null;
            XmlTextReader reader = new XmlTextReader(path);
            //Se indica el tipo de objeto ha serializar.
            XmlSerializer ser = new XmlSerializer(typeof(Persona));
            p = (Persona)ser.Deserialize(reader);
            return p;

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre : {this.nombre} Apellido : {this.apellido}");
            return sb.ToString();
        }
    }
}
