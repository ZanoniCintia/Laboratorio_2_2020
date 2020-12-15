using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ArchivoDeTexto02
{
    class Program
    {
      
        static void Main(string[] args)
        {
               string file_name = AppDomain.CurrentDomain.BaseDirectory+ "TestFile2.txt";

           
            try
            {
                if (File.Exists(file_name))
                {
                    char rta;
                    Console.WriteLine("El archivo {0} ya existe. Desea sobre escribir?", file_name);
                    rta = char.Parse(Console.ReadLine());

                    if (rta == 's')
                    {
                        using (StreamWriter sw = new StreamWriter(@"C:\TestFile2.txt"))
                        {
                            sw.Write("Este es el ");
                            sw.WriteLine("Encabezado para el archivo.");
                            sw.WriteLine("-----------------------------");
                            sw.WriteLine("ARCHIVO SOBRESCRITO....");
                        }
                    }
                    else
                    {
                        using (StreamWriter sw = new StreamWriter(file_name,true))
                        {
                            sw.WriteLine("Linea agregada al archivo original...");
                        }
                    }
                }
                else
                {
                    // si no existe el archivo
                    using (StreamWriter sw = new StreamWriter(file_name))
                    {
                        sw.Write("Este es el ");
                        sw.WriteLine("Encabezado para el archivo.");
                        sw.WriteLine("-----------------------------");
                        sw.Write("ARCHIVO NUEVO");
                        sw.Close();
                    }
                }

                Console.WriteLine("El archivo fue escrito exitosamente.....");
                Console.WriteLine(" ");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            try
            {
                using (StreamReader sr = new StreamReader(file_name))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("Datos recuperados desde el archivo.....");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Error en el archivo ubicado en {0}", file_name);
                Console.WriteLine(e.Message);
            }

            finally 
            {
                Console.ReadLine();
            }
        }
    }
}
