using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Entidades
{
   public class ArchivoTexto : IArchivo<string>
    {   

        /// <summary>
        /// guarda archivo de texto plano 
        /// </summary>
        /// <param name="nombreArchivo"></param>
        /// <param name="rutaArchivo"></param>
        /// <param name="textAGuardar"></param>
        /// <returns></returns>
        public bool Escribir(string nombreArchivo, string rutaArchivo, string textAGuardar)
        {
            bool rutaCreada = false;
            try
            {
                if (!Directory.Exists(rutaArchivo))
                {
                    Directory.CreateDirectory(rutaArchivo);
                     rutaCreada = true;
                }
                using (StreamWriter miArchivo = new StreamWriter(rutaArchivo + nombreArchivo, true))
                {
                    miArchivo.WriteLine("********************* \n");
                    miArchivo.WriteLine(textAGuardar);
                    miArchivo.WriteLine("********************* \n");
                    
                }

                if (rutaCreada)
                {
                    throw new RutaNoExisteException("Ruta de archivo log fue creada a mano. La ruta creada fue " + rutaArchivo);
                }


                return true;
            }
            catch (RutaNoExisteException ex)
            {

               return this.Escribir(nombreArchivo, rutaArchivo, ex.Message);
              
            }
            catch (Exception)
            {

                return false;
            }
           
        }

        public bool Leer(string archivo, out string datos)
        {
            throw new NotImplementedException();
        }
    }
}
