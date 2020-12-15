using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ArchivoDeTexto01
{
    class Program
    {

        static void Main(string[] args)
        {


            string file_name = AppDomain.CurrentDomain.BaseDirectory + "TestFile1.txt";

        
            //Crea una instancia de StreamWriter para escribir un texto a un archivo.
            try
            {
                using (StreamWriter sw = new StreamWriter(file_name))
                {
                    // Agrega algun texto al archivo.

                    sw.Write("Este es el ");
                    sw.WriteLine("Encabezado para el archivo.");
                    sw.WriteLine("-----------------------------");

                    // Objetos arbitrarios tambien pueden ser escritos en el archivo.

                    sw.Write("lA FECHA ES: ");
                    sw.WriteLine(DateTime.Now);
                }


                Console.Clear();

                // Crea una instancia de StreamReader para leer desde el archivo.

                using (StreamReader sr = new StreamReader(file_name))
                {
                    String line;

                    // Lee y muestra lineas desde el archivo hasta el fin del mismo.

                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine("Datos recuperados desde el archivo.....");
                    Console.ReadLine();
                
                }
                
            }
            catch (Exception e)
            {

                Console.WriteLine("Error en el archivo ubicado en {0}", file_name);
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("Pulse cualquier tecla para salir...");
                Console.ReadLine();
            }

        }
    }
}
