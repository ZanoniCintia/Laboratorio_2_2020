using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{   
  
     public interface IArchivo<T>
     {  
        /// <summary>
        /// metodo de interfaz a implementar en clases que la reciban 
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="path"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
         bool Escribir(string archivo,string path, T datos);
         bool Leer(string archivo, out T datos);
     }
  
}
