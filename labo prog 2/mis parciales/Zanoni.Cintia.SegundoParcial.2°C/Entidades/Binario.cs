using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Entidades
{

    public class Binario<T> : IArchivo<T>
    {
        /// <summary>
        /// Serializa un objeto en formato binario 
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="ruta"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Escribir(string archivo,string ruta, T datos)
        {
            Stream stream = null;
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                stream = new FileStream( ruta + archivo, FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, datos);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (!ReferenceEquals(stream, null))
                    stream.Close();
            }
        }

        /// <summary>
        /// lee archivo en formato binario
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Leer(string archivo, out T datos)
        {
            Stream stream = null;
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                stream = new FileStream(archivo, FileMode.Open, FileAccess.Read, FileShare.Read);
                datos = (T)formatter.Deserialize(stream);
                //stream.Close();
                return true;
            }
            catch (Exception)
            {
                datos = default(T);
                return false;
            }
            finally
            {
                if (!ReferenceEquals(stream, null))
                    stream.Close();
            }
        }
    }
}