﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Interfaz_50
{
    public interface IGuardar<T,V>
    {
        bool Guardar(T obj);

        V Leer();
    }
}
