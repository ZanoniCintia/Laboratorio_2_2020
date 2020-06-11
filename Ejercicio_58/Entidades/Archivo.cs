using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace IO
{
    public abstract class Archivo
    {
        protected virtual bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            bool retorno = false;
            if(validaExistencia && File.Exists(ruta))
            {
                retorno = true;
            }
            else
            {
                throw new FileNotFoundException();
            }

            return retorno;
        }
    }
}
